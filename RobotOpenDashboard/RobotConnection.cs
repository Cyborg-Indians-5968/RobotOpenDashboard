using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace RobotOpenDashboard
{
    public sealed class RobotConnection
    {
        private readonly UdpClient UdpSend;
        private readonly UdpClient UdpReceive;
        private readonly IPEndPoint RobotEndpoint;
        private const int RobotOpenPort = 22211;
        private readonly Thread ReceiveThread;

        public event Action<string> DebugMessageReceived;

        public RobotConnection(IPAddress robotIp)
        {
            RobotEndpoint = new IPEndPoint(robotIp, RobotOpenPort);
            UdpSend = new UdpClient();
            UdpReceive = new UdpClient(RobotOpenPort);

            ReceiveThread = new Thread(ReceiveThreadEntry);
            ReceiveThread.Start();
        }

        private void ReceiveThreadEntry()
        {
            Thread.CurrentThread.Name = "RobotOpen receive thread";

            while (true)
            {
                IPEndPoint endpoint = RobotEndpoint;
                byte[] packet = UdpReceive.Receive(ref endpoint);

                if(packet.Length < 1)
                {
                    Console.Error.WriteLine("Received unexpected empty packet!");
                    continue;
                }

                PacketId packetId = (PacketId)packet[0];
                HandlePacket(packetId, packet.AsSpan().Slice(sizeof(PacketId)));
            }
        }

        private void HandlePacket(PacketId id, ReadOnlySpan<byte> data) 
        {
            if (id == PacketId.DashboardData)
            {
                return;
            }

            if (id != PacketId.DebugMessage)
            {
                Console.Error.WriteLine($"Received unhandled packet {id} from robot.");
                return;
            }

            string debugMessage = Encoding.ASCII.GetString(data.ToArray(), 0, data.Length);
            DebugMessageReceived?.Invoke(debugMessage);
        }

        public unsafe void Send<TData>(PacketId id, in TData data)
            where TData : unmanaged
        {
            var packet = new byte[sizeof(PacketId) + Marshal.SizeOf<TData>() + sizeof(ushort)];
            packet[0] = (byte)id;

            fixed (byte* packetData = packet)
            {
                Marshal.StructureToPtr(data, (IntPtr)(packetData + sizeof(PacketId)), false);
            }

            ushort crc = RobotOpenCrc16.Calculate(packet.AsSpan().Slice(0, packet.Length - sizeof(ushort)));

            packet[packet.Length - 2] = (byte)(crc >> 8);
            packet[packet.Length - 1] = (byte)(crc & 0xFF);

            UdpSend.Send(packet, packet.Length, RobotEndpoint);
        }
    }
}

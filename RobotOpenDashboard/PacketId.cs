namespace RobotOpenDashboard
{
    public enum PacketId : byte
    {
        // Driver Station to Robot
        Control = 0x63, 
        Heartbeat = 0x68,
        SetParameter = 0x73,
        GetParameters = 0x67,

        // Robot to Driver Station
        DebugMessage = 0x70,
        DashboardData = 0x64,
        ParameterData = 0x72,
    }
}

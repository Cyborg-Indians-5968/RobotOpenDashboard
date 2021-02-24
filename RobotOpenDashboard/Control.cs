using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using SharpDX.XInput;

namespace RobotOpenDashboard
{
    class Control
    {
        public static bool isEnabled = false;
        public static bool joystickControl = false;

        public static sbyte manualLeftSpeed = 0;
        public static sbyte manualRightSpeed = 0;

        private static Controller controller;
        private static RobotConnection connection;

        public static void InitializeRobot()
        {
            int userIndex = 0;
            while (!IsUserIndexOk(userIndex))
            {
                userIndex++;
            }
            controller = new Controller(IntToUserIndex(userIndex));
            connection = new RobotConnection(IPAddress.Parse("10.59.68.5"));

            connection.DebugMessageReceived += message => Console.WriteLine(message);
        }

        public static void ControlRobot()
        {
            if (isEnabled)
            {
                Joystick joystick = new Joystick();
                State state = controller.GetState();

                if (joystickControl)
                {
                    ProcessJoystick(state.Gamepad.LeftThumbX, state.Gamepad.LeftThumbY, out joystick.LeftX, out joystick.LeftY);

                    ProcessJoystick(state.Gamepad.RightThumbX, state.Gamepad.RightThumbY, out joystick.RightX, out joystick.RightY);

                    joystick.ButtonA = (state.Gamepad.Buttons & GamepadButtonFlags.A) != 0;
                    joystick.ButtonB = (state.Gamepad.Buttons & GamepadButtonFlags.B) != 0;
                    joystick.ButtonX = (state.Gamepad.Buttons & GamepadButtonFlags.X) != 0;
                    joystick.ButtonY = (state.Gamepad.Buttons & GamepadButtonFlags.Y) != 0;

                    joystick.LeftShoulder = (state.Gamepad.Buttons & GamepadButtonFlags.LeftShoulder) != 0;
                    joystick.RightShoulder = (state.Gamepad.Buttons & GamepadButtonFlags.RightShoulder) != 0;

                    double leftTrigger = state.Gamepad.LeftTrigger;
                    leftTrigger = leftTrigger > Gamepad.TriggerThreshold ? leftTrigger : 0;
                    joystick.LeftTrigger = Convert.ToByte(Math.Floor(leftTrigger));

                    double rightTrigger = state.Gamepad.RightTrigger;
                    rightTrigger = rightTrigger > Gamepad.TriggerThreshold ? rightTrigger : 0;
                    joystick.RightTrigger = Convert.ToByte(Math.Floor(rightTrigger));

                    joystick.SelectButton = (state.Gamepad.Buttons & GamepadButtonFlags.Back) != 0;
                    joystick.StartButton = (state.Gamepad.Buttons & GamepadButtonFlags.Start) != 0;

                    joystick.LeftStickButton = (state.Gamepad.Buttons & GamepadButtonFlags.LeftThumb) != 0;
                    joystick.RightStickButton = (state.Gamepad.Buttons & GamepadButtonFlags.RightThumb) != 0;

                    joystick.DPadUp = (state.Gamepad.Buttons & GamepadButtonFlags.DPadUp) != 0;
                    joystick.DPadDown = (state.Gamepad.Buttons & GamepadButtonFlags.DPadDown) != 0;
                    joystick.DPadLeft = (state.Gamepad.Buttons & GamepadButtonFlags.DPadLeft) != 0;
                    joystick.DPadRight = (state.Gamepad.Buttons & GamepadButtonFlags.DPadRight) != 0;
                } else
                {
                    joystick.LeftY = manualLeftSpeed;
                    joystick.RightY = manualRightSpeed;
                }

                connection.Send(PacketId.Control, joystick);
            }
        }

        private static bool IsUserIndexOk(int userIndex)
        {
            Controller controller = new Controller(IntToUserIndex(userIndex));
            try
            {
                controller.GetState();
            }
            catch (SharpDX.SharpDXException)
            {
                return false;
            }
            return true;
        }

        private static UserIndex IntToUserIndex(int userIndex)
        {
            switch (userIndex)
            {
                case 0:
                    return UserIndex.One;
                case 1:
                    return UserIndex.Two;
                case 2:
                    return UserIndex.Three;
                case 3:
                    return UserIndex.Four;
                default:
                    return UserIndex.Any;
            }
        }

        private static void ProcessJoystick(short inX, short inY, out sbyte outX, out sbyte outY)
        {
            double x = inX;
            double y = inY;
            double magnitude = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            magnitude = magnitude > short.MaxValue ? (double)short.MaxValue : magnitude;

            if (magnitude > Gamepad.LeftThumbDeadZone)
            {
                x = (x / (double)short.MaxValue) * ((double)sbyte.MaxValue);
                y = (y / (double)short.MaxValue) * ((double)sbyte.MaxValue);
            }
            else
            {
                x = 0;
                y = 0;
            }

            outX = (sbyte)x;
            outY = (sbyte)y;
        }
    }
}

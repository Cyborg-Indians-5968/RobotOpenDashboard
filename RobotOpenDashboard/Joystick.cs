namespace RobotOpenDashboard
{
    public struct Joystick
    {
        public sbyte LeftX;
        public sbyte LeftY;
        public sbyte RightX;
        public sbyte RightY;

        private const byte RoTrue = 0xFF;
        private const byte RoFalse = 0x00;

        private byte _ButtonA;
        public bool ButtonA
        {
            get => _ButtonA != 0;
            set => _ButtonA = value ? RoTrue : RoFalse;
        }

        private byte _ButtonB;
        public bool ButtonB
        {
            get => _ButtonB != 0;
            set => _ButtonB = value ? RoTrue : RoFalse;
        }

        private byte _ButtonX;
        public bool ButtonX
        {
            get => _ButtonX != 0;
            set => _ButtonX = value ? RoTrue : RoFalse;
        }

        private byte _ButtonY;
        public bool ButtonY
        {
            get => _ButtonY != 0;
            set => _ButtonY = value ? RoTrue : RoFalse;
        }

        private byte _LeftShoulder;
        public bool LeftShoulder
        {
            get => _LeftShoulder != 0;
            set => _LeftShoulder = value ? RoTrue : RoFalse;
        }

        private byte _RightShoulder;
        public bool RightShoulder
        {
            get => _RightShoulder != 0;
            set => _RightShoulder = value ? RoTrue : RoFalse;
        }

        public byte LeftTrigger;
        public byte RightTrigger;

        private byte _SelectButton;
        public bool SelectButton
        {
            get => _SelectButton != 0;
            set => _SelectButton = value ? RoTrue : RoFalse;
        }

        private byte _StartButton;
        public bool StartButton
        {
            get => _StartButton != 0;
            set => _StartButton = value ? RoTrue : RoFalse;
        }

        private byte _LeftStickButton;
        public bool LeftStickButton
        {
            get => _LeftStickButton != 0;
            set => _LeftStickButton = value ? RoTrue : RoFalse;
        }

        private byte _RightStickButton;
        public bool RightStickButton
        {
            get => _RightStickButton != 0;
            set => _RightStickButton = value ? RoTrue : RoFalse;
        }

        private byte _DPadUp;
        public bool DPadUp
        {
            get => _DPadUp != 0;
            set => _DPadUp = value ? RoTrue : RoFalse;
        }

        private byte _DPadDown;
        public bool DPadDown
        {
            get => _DPadDown != 0;
            set => _DPadDown = value ? RoTrue : RoFalse;
        }

        private byte _DPadLeft;
        public bool DPadLeft
        {
            get => _DPadLeft != 0;
            set => _DPadLeft = value ? RoTrue : RoFalse;
        }

        private byte _DPadRight;
        public bool DPadRight
        {
            get => _DPadRight != 0;
            set => _DPadRight = value ? RoTrue : RoFalse;
        }

        public byte Aux1;
        public byte Aux2;
        public byte Aux3;
        public byte Aux4;
    }
}

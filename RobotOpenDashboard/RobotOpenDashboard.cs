using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotOpenDashboard
{
    public partial class RobotOpenDashboard : Form
    {
        public RobotOpenDashboard()
        {
            InitializeComponent();
            Control.InitializeRobot();
            timer.Start();
        }

        private void enableButton_Click(object sender, EventArgs e)
        {
            Control.isEnabled = true;

            disableButton.Enabled = true;
            enableButton.Enabled = false;
        }

        private void disableButton_Click(object sender, EventArgs e)
        {
            Control.isEnabled = false;

            enableButton.Enabled = true;
            disableButton.Enabled = false;
        }

        private void joystickControlButton_Click(object sender, EventArgs e)
        {
            Control.joystickControl = true;

            manualControlButton.Enabled = true;
            joystickControlButton.Enabled = false;
            instructions.ForeColor = Color.Black;
            leftMotorControl.Enabled = false;
            leftMotorLabel.ForeColor = Color.LightGray;
            leftMotorBox.Enabled = false;
            rightMotorControl.Enabled = false;
            rightMotorLabel.ForeColor = Color.LightGray;
            rightMotorBox.Enabled = false;
            speedPercentageLabel.ForeColor = Color.LightGray;

        }

        private void manualControlButton_Click(object sender, EventArgs e)
        {
            Control.joystickControl = false;

            joystickControlButton.Enabled = true;
            manualControlButton.Enabled = false;
            instructions.ForeColor = Color.LightGray;
            leftMotorControl.Enabled = true;
            leftMotorLabel.ForeColor = Color.Black;
            leftMotorBox.Enabled = true;
            rightMotorControl.Enabled = true;
            rightMotorLabel.ForeColor = Color.Black;
            rightMotorBox.Enabled = true;
            speedPercentageLabel.ForeColor = Color.Black;

        }

        private void leftMotorControl_Scroll(object sender, EventArgs e)
        {
            leftMotorBox.Text = leftMotorControl.Value.ToString();
            Control.manualLeftSpeed = (sbyte)leftMotorControl.Value;
        }

        private void rightMotorControl_Scroll(object sender, EventArgs e)
        {
            rightMotorBox.Text = rightMotorControl.Value.ToString();
            Control.manualRightSpeed = (sbyte)rightMotorControl.Value;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Control.ControlRobot();
        }

        private void RobotOpenDashboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Control.isEnabled = false;

                enableButton.Enabled = true;
                disableButton.Enabled = false;
            }
        }

        private void leftMotorBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                leftMotorControl.Value = leftMotorBox.Text.Length == 0 ? 0 : Int32.Parse(leftMotorBox.Text);
            } catch (Exception)
            {
                
            }
        }

        private void rightMotorBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rightMotorControl.Value = rightMotorBox.Text.Length == 0 ? 0 : Int32.Parse(rightMotorBox.Text);
            } catch (Exception)
            {

            }
        }
    }
}

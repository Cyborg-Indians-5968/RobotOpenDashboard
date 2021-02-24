using System.Windows.Forms;

namespace RobotOpenDashboard
{
    partial class RobotOpenDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RobotOpenDashboard));
            this.title = new System.Windows.Forms.Label();
            this.enableButton = new NoFocusCueButton();
            this.disableButton = new NoFocusCueButton();
            this.joystickControlButton = new NoFocusCueButton();
            this.manualControlButton = new NoFocusCueButton();
            this.instructions = new System.Windows.Forms.Label();
            this.divider = new System.Windows.Forms.Label();
            this.rightMotorControl = new System.Windows.Forms.TrackBar();
            this.leftMotorControl = new System.Windows.Forms.TrackBar();
            this.leftMotorLabel = new System.Windows.Forms.Label();
            this.rightMotorLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.speedPercentageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.leftMotorBox = new System.Windows.Forms.TextBox();
            this.rightMotorBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rightMotorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMotorControl)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(521, 55);
            this.title.TabIndex = 0;
            this.title.Text = "RobotOpen Dashboard";
            // 
            // enableButton
            // 
            this.enableButton.Location = new System.Drawing.Point(541, 12);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(108, 38);
            this.enableButton.TabIndex = 1;
            this.enableButton.Text = "Enable";
            this.enableButton.UseVisualStyleBackColor = true;
            this.enableButton.Click += new System.EventHandler(this.enableButton_Click);
            // 
            // disableButton
            // 
            this.disableButton.Enabled = false;
            this.disableButton.Location = new System.Drawing.Point(680, 12);
            this.disableButton.Name = "disableButton";
            this.disableButton.Size = new System.Drawing.Size(108, 38);
            this.disableButton.TabIndex = 2;
            this.disableButton.Text = "Disable";
            this.disableButton.UseVisualStyleBackColor = true;
            this.disableButton.Click += new System.EventHandler(this.disableButton_Click);
            // 
            // joystickControlButton
            // 
            this.joystickControlButton.Enabled = false;
            this.joystickControlButton.Location = new System.Drawing.Point(10, 74);
            this.joystickControlButton.Name = "joystickControlButton";
            this.joystickControlButton.Size = new System.Drawing.Size(108, 53);
            this.joystickControlButton.TabIndex = 3;
            this.joystickControlButton.Text = "Joystick Control";
            this.joystickControlButton.UseVisualStyleBackColor = true;
            this.joystickControlButton.Click += new System.EventHandler(this.joystickControlButton_Click);
            // 
            // manualControlButton
            // 
            this.manualControlButton.Location = new System.Drawing.Point(10, 208);
            this.manualControlButton.Name = "manualControlButton";
            this.manualControlButton.Size = new System.Drawing.Size(108, 53);
            this.manualControlButton.TabIndex = 4;
            this.manualControlButton.Text = "Manual Control";
            this.manualControlButton.UseVisualStyleBackColor = true;
            this.manualControlButton.Click += new System.EventHandler(this.manualControlButton_Click);
            // 
            // instructions
            // 
            this.instructions.AutoSize = true;
            this.instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.instructions.Location = new System.Drawing.Point(143, 74);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(627, 144);
            this.instructions.TabIndex = 5;
            this.instructions.Text = resources.GetString("instructions.Text");
            // 
            // divider
            // 
            this.divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider.Location = new System.Drawing.Point(10, 190);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(783, 2);
            this.divider.TabIndex = 6;
            this.divider.Text = "label2";
            // 
            // rightMotorControl
            // 
            this.rightMotorControl.Enabled = false;
            this.rightMotorControl.LargeChange = 8;
            this.rightMotorControl.Location = new System.Drawing.Point(283, 290);
            this.rightMotorControl.Maximum = 127;
            this.rightMotorControl.Minimum = -128;
            this.rightMotorControl.Name = "rightMotorControl";
            this.rightMotorControl.Size = new System.Drawing.Size(446, 69);
            this.rightMotorControl.TabIndex = 8;
            this.rightMotorControl.TickFrequency = 2;
            this.rightMotorControl.Scroll += new System.EventHandler(this.rightMotorControl_Scroll);
            this.rightMotorControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RobotOpenDashboard_KeyDown);
            // 
            // leftMotorControl
            // 
            this.leftMotorControl.Enabled = false;
            this.leftMotorControl.LargeChange = 8;
            this.leftMotorControl.Location = new System.Drawing.Point(283, 215);
            this.leftMotorControl.Maximum = 127;
            this.leftMotorControl.Minimum = -128;
            this.leftMotorControl.Name = "leftMotorControl";
            this.leftMotorControl.Size = new System.Drawing.Size(446, 69);
            this.leftMotorControl.TabIndex = 7;
            this.leftMotorControl.TickFrequency = 2;
            this.leftMotorControl.Scroll += new System.EventHandler(this.leftMotorControl_Scroll);
            this.leftMotorControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RobotOpenDashboard_KeyDown);
            // 
            // leftMotorLabel
            // 
            this.leftMotorLabel.AutoSize = true;
            this.leftMotorLabel.ForeColor = System.Drawing.Color.Silver;
            this.leftMotorLabel.Location = new System.Drawing.Point(144, 215);
            this.leftMotorLabel.Name = "leftMotorLabel";
            this.leftMotorLabel.Size = new System.Drawing.Size(133, 20);
            this.leftMotorLabel.TabIndex = 9;
            this.leftMotorLabel.Text = "Left Motor Speed";
            // 
            // rightMotorLabel
            // 
            this.rightMotorLabel.AutoSize = true;
            this.rightMotorLabel.ForeColor = System.Drawing.Color.Silver;
            this.rightMotorLabel.Location = new System.Drawing.Point(134, 290);
            this.rightMotorLabel.Name = "rightMotorLabel";
            this.rightMotorLabel.Size = new System.Drawing.Size(143, 20);
            this.rightMotorLabel.TabIndex = 10;
            this.rightMotorLabel.Text = "Right Motor Speed";
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // speedPercentageLabel
            // 
            this.speedPercentageLabel.AutoSize = true;
            this.speedPercentageLabel.ForeColor = System.Drawing.Color.Silver;
            this.speedPercentageLabel.Location = new System.Drawing.Point(17, 267);
            this.speedPercentageLabel.Name = "speedPercentageLabel";
            this.speedPercentageLabel.Size = new System.Drawing.Size(94, 80);
            this.speedPercentageLabel.TabIndex = 13;
            this.speedPercentageLabel.Text = "100% = 128\r\n75% = 96\r\n50% = 64\r\n25% = 32";
            this.speedPercentageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(731, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Team 5968";
            // 
            // leftMotorBox
            // 
            this.leftMotorBox.Enabled = false;
            this.leftMotorBox.Location = new System.Drawing.Point(735, 221);
            this.leftMotorBox.MaxLength = 4;
            this.leftMotorBox.Name = "leftMotorBox";
            this.leftMotorBox.Size = new System.Drawing.Size(71, 26);
            this.leftMotorBox.TabIndex = 15;
            this.leftMotorBox.Text = "0";
            this.leftMotorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.leftMotorBox.TextChanged += new System.EventHandler(this.leftMotorBox_TextChanged);
            // 
            // rightMotorBox
            // 
            this.rightMotorBox.Enabled = false;
            this.rightMotorBox.Location = new System.Drawing.Point(735, 294);
            this.rightMotorBox.MaxLength = 4;
            this.rightMotorBox.Name = "rightMotorBox";
            this.rightMotorBox.Size = new System.Drawing.Size(71, 26);
            this.rightMotorBox.TabIndex = 16;
            this.rightMotorBox.Text = "0";
            this.rightMotorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rightMotorBox.TextChanged += new System.EventHandler(this.rightMotorBox_TextChanged);
            // 
            // RobotOpenDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 364);
            this.Controls.Add(this.rightMotorBox);
            this.Controls.Add(this.leftMotorBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speedPercentageLabel);
            this.Controls.Add(this.rightMotorLabel);
            this.Controls.Add(this.leftMotorLabel);
            this.Controls.Add(this.leftMotorControl);
            this.Controls.Add(this.rightMotorControl);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.manualControlButton);
            this.Controls.Add(this.joystickControlButton);
            this.Controls.Add(this.disableButton);
            this.Controls.Add(this.enableButton);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RobotOpenDashboard";
            this.Text = "RobotOpen Dashboard 2020";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RobotOpenDashboard_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.rightMotorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMotorControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label instructions;
        private System.Windows.Forms.Label divider;
        private System.Windows.Forms.TrackBar rightMotorControl;
        private System.Windows.Forms.TrackBar leftMotorControl;
        private System.Windows.Forms.Label leftMotorLabel;
        private System.Windows.Forms.Label rightMotorLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label speedPercentageLabel;
        private System.Windows.Forms.Label label1;
        private NoFocusCueButton enableButton;
        private NoFocusCueButton disableButton;
        private NoFocusCueButton joystickControlButton;
        private NoFocusCueButton manualControlButton;
        private TextBox leftMotorBox;
        private TextBox rightMotorBox;

    }

    public class NoFocusCueButton : Button
    {
        public NoFocusCueButton()
        {
            this.SetStyle(ControlStyles.Selectable, false);
        }

        protected override bool ShowFocusCues
        {
            get
            {
                return false;
            }
        }
    }
}


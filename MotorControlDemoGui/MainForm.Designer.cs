namespace MotorControlDemoGui
{
    partial class MainForm
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
            this.panelConnection = new System.Windows.Forms.Panel();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlDashboard = new System.Windows.Forms.TabControl();
            this.tabConnection = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelActualSpeed = new System.Windows.Forms.Label();
            this.labelTargetSpeed = new System.Windows.Forms.Label();
            this.radioBtnDirectionCCW = new System.Windows.Forms.RadioButton();
            this.radioBtnDirection = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSpeedValSet = new System.Windows.Forms.Label();
            this.labelAccVal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelSpeedValMin = new System.Windows.Forms.Label();
            this.labelSpeedValMax = new System.Windows.Forms.Label();
            this.trackBarAcceleration = new System.Windows.Forms.TrackBar();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.btnStopMotor = new System.Windows.Forms.Button();
            this.btnApplySpeed = new System.Windows.Forms.Button();
            this.timerMotorState = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.labelMotorState = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelConnection.SuspendLayout();
            this.tabControlDashboard.SuspendLayout();
            this.tabConnection.SuspendLayout();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAcceleration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConnection
            // 
            this.panelConnection.Controls.Add(this.comboBoxComPort);
            this.panelConnection.Controls.Add(this.btnConnect);
            this.panelConnection.Controls.Add(this.label1);
            this.panelConnection.Location = new System.Drawing.Point(101, 104);
            this.panelConnection.Name = "panelConnection";
            this.panelConnection.Size = new System.Drawing.Size(303, 84);
            this.panelConnection.TabIndex = 0;
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(55, 17);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxComPort.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(182, 17);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // tabControlDashboard
            // 
            this.tabControlDashboard.Controls.Add(this.tabConnection);
            this.tabControlDashboard.Controls.Add(this.tabControl);
            this.tabControlDashboard.Location = new System.Drawing.Point(26, 30);
            this.tabControlDashboard.Name = "tabControlDashboard";
            this.tabControlDashboard.SelectedIndex = 0;
            this.tabControlDashboard.Size = new System.Drawing.Size(618, 504);
            this.tabControlDashboard.TabIndex = 1;
            // 
            // tabConnection
            // 
            this.tabConnection.Controls.Add(this.panelConnection);
            this.tabConnection.Location = new System.Drawing.Point(4, 22);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnection.Size = new System.Drawing.Size(610, 478);
            this.tabConnection.TabIndex = 0;
            this.tabConnection.Text = "Connection";
            this.tabConnection.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.label10);
            this.tabControl.Controls.Add(this.label6);
            this.tabControl.Controls.Add(this.labelMotorState);
            this.tabControl.Controls.Add(this.labelActualSpeed);
            this.tabControl.Controls.Add(this.labelTargetSpeed);
            this.tabControl.Controls.Add(this.radioBtnDirectionCCW);
            this.tabControl.Controls.Add(this.radioBtnDirection);
            this.tabControl.Controls.Add(this.label12);
            this.tabControl.Controls.Add(this.label11);
            this.tabControl.Controls.Add(this.label8);
            this.tabControl.Controls.Add(this.label4);
            this.tabControl.Controls.Add(this.label2);
            this.tabControl.Controls.Add(this.label3);
            this.tabControl.Controls.Add(this.labelSpeedValSet);
            this.tabControl.Controls.Add(this.labelAccVal);
            this.tabControl.Controls.Add(this.label14);
            this.tabControl.Controls.Add(this.label13);
            this.tabControl.Controls.Add(this.labelSpeedValMin);
            this.tabControl.Controls.Add(this.labelSpeedValMax);
            this.tabControl.Controls.Add(this.trackBarAcceleration);
            this.tabControl.Controls.Add(this.trackBarSpeed);
            this.tabControl.Controls.Add(this.btnStopMotor);
            this.tabControl.Controls.Add(this.btnApplySpeed);
            this.tabControl.Location = new System.Drawing.Point(4, 22);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabControl.Size = new System.Drawing.Size(610, 478);
            this.tabControl.TabIndex = 1;
            this.tabControl.Text = "Control";
            this.tabControl.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(460, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 39);
            this.label10.TabIndex = 12;
            this.label10.Text = "RPM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(457, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 39);
            this.label6.TabIndex = 12;
            this.label6.Text = "RPM";
            // 
            // labelActualSpeed
            // 
            this.labelActualSpeed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelActualSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActualSpeed.Location = new System.Drawing.Point(173, 340);
            this.labelActualSpeed.Name = "labelActualSpeed";
            this.labelActualSpeed.Size = new System.Drawing.Size(281, 52);
            this.labelActualSpeed.TabIndex = 12;
            this.labelActualSpeed.Text = "0";
            this.labelActualSpeed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTargetSpeed
            // 
            this.labelTargetSpeed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelTargetSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTargetSpeed.Location = new System.Drawing.Point(173, 279);
            this.labelTargetSpeed.Name = "labelTargetSpeed";
            this.labelTargetSpeed.Size = new System.Drawing.Size(279, 52);
            this.labelTargetSpeed.TabIndex = 12;
            this.labelTargetSpeed.Text = "0";
            this.labelTargetSpeed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // radioBtnDirectionCCW
            // 
            this.radioBtnDirectionCCW.AutoSize = true;
            this.radioBtnDirectionCCW.Location = new System.Drawing.Point(295, 186);
            this.radioBtnDirectionCCW.Name = "radioBtnDirectionCCW";
            this.radioBtnDirectionCCW.Size = new System.Drawing.Size(113, 17);
            this.radioBtnDirectionCCW.TabIndex = 11;
            this.radioBtnDirectionCCW.TabStop = true;
            this.radioBtnDirectionCCW.Text = "Counter-Clockwise";
            this.radioBtnDirectionCCW.UseVisualStyleBackColor = true;
            // 
            // radioBtnDirection
            // 
            this.radioBtnDirection.AutoSize = true;
            this.radioBtnDirection.Checked = true;
            this.radioBtnDirection.Location = new System.Drawing.Point(175, 186);
            this.radioBtnDirection.Name = "radioBtnDirection";
            this.radioBtnDirection.Size = new System.Drawing.Size(73, 17);
            this.radioBtnDirection.TabIndex = 11;
            this.radioBtnDirection.TabStop = true;
            this.radioBtnDirection.Text = "Clockwise";
            this.radioBtnDirection.UseVisualStyleBackColor = true;
            this.radioBtnDirection.CheckedChanged += new System.EventHandler(this.radioBtnDirection_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Actual Speed:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Target Speed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Target Speed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Acceleration:";
            // 
            // labelSpeedValSet
            // 
            this.labelSpeedValSet.AutoSize = true;
            this.labelSpeedValSet.Location = new System.Drawing.Point(292, 155);
            this.labelSpeedValSet.Name = "labelSpeedValSet";
            this.labelSpeedValSet.Size = new System.Drawing.Size(55, 13);
            this.labelSpeedValSet.TabIndex = 2;
            this.labelSpeedValSet.Text = "1000RPM";
            // 
            // labelAccVal
            // 
            this.labelAccVal.AutoSize = true;
            this.labelAccVal.Location = new System.Drawing.Point(306, 245);
            this.labelAccVal.Name = "labelAccVal";
            this.labelAccVal.Size = new System.Drawing.Size(31, 13);
            this.labelAccVal.TabIndex = 2;
            this.labelAccVal.Text = "2400";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(421, 245);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "3200";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(172, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "64";
            // 
            // labelSpeedValMin
            // 
            this.labelSpeedValMin.AutoSize = true;
            this.labelSpeedValMin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelSpeedValMin.Location = new System.Drawing.Point(172, 155);
            this.labelSpeedValMin.Name = "labelSpeedValMin";
            this.labelSpeedValMin.Size = new System.Drawing.Size(49, 13);
            this.labelSpeedValMin.TabIndex = 2;
            this.labelSpeedValMin.Text = "500RPM";
            // 
            // labelSpeedValMax
            // 
            this.labelSpeedValMax.AutoSize = true;
            this.labelSpeedValMax.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelSpeedValMax.Location = new System.Drawing.Point(390, 155);
            this.labelSpeedValMax.Name = "labelSpeedValMax";
            this.labelSpeedValMax.Size = new System.Drawing.Size(64, 13);
            this.labelSpeedValMax.TabIndex = 2;
            this.labelSpeedValMax.Text = "13,000RPM";
            // 
            // trackBarAcceleration
            // 
            this.trackBarAcceleration.LargeChange = 50;
            this.trackBarAcceleration.Location = new System.Drawing.Point(173, 213);
            this.trackBarAcceleration.Maximum = 3200;
            this.trackBarAcceleration.Minimum = 64;
            this.trackBarAcceleration.Name = "trackBarAcceleration";
            this.trackBarAcceleration.Size = new System.Drawing.Size(279, 45);
            this.trackBarAcceleration.SmallChange = 10;
            this.trackBarAcceleration.TabIndex = 1;
            this.trackBarAcceleration.TickFrequency = 100;
            this.trackBarAcceleration.Value = 2400;
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.LargeChange = 500;
            this.trackBarSpeed.Location = new System.Drawing.Point(173, 123);
            this.trackBarSpeed.Maximum = 13000;
            this.trackBarSpeed.Minimum = 500;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(281, 45);
            this.trackBarSpeed.SmallChange = 100;
            this.trackBarSpeed.TabIndex = 1;
            this.trackBarSpeed.TickFrequency = 500;
            this.trackBarSpeed.Value = 1000;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // btnStopMotor
            // 
            this.btnStopMotor.AutoEllipsis = true;
            this.btnStopMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopMotor.ForeColor = System.Drawing.Color.Red;
            this.btnStopMotor.Location = new System.Drawing.Point(173, 32);
            this.btnStopMotor.Name = "btnStopMotor";
            this.btnStopMotor.Size = new System.Drawing.Size(281, 57);
            this.btnStopMotor.TabIndex = 0;
            this.btnStopMotor.Text = "Stop Motor";
            this.btnStopMotor.UseVisualStyleBackColor = true;
            this.btnStopMotor.Click += new System.EventHandler(this.btnStopMotor_Click);
            // 
            // btnApplySpeed
            // 
            this.btnApplySpeed.AutoEllipsis = true;
            this.btnApplySpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnApplySpeed.ForeColor = System.Drawing.Color.Green;
            this.btnApplySpeed.Location = new System.Drawing.Point(464, 120);
            this.btnApplySpeed.Name = "btnApplySpeed";
            this.btnApplySpeed.Size = new System.Drawing.Size(80, 48);
            this.btnApplySpeed.TabIndex = 0;
            this.btnApplySpeed.Text = "Apply Speed";
            this.btnApplySpeed.UseVisualStyleBackColor = true;
            this.btnApplySpeed.Click += new System.EventHandler(this.btnApplySpeed_Click);
            // 
            // timerMotorState
            // 
            this.timerMotorState.Enabled = true;
            this.timerMotorState.Interval = 300;
            this.timerMotorState.Tick += new System.EventHandler(this.timerMotorState_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(32, 419);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "Motor State:";
            // 
            // labelMotorState
            // 
            this.labelMotorState.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelMotorState.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotorState.Location = new System.Drawing.Point(173, 401);
            this.labelMotorState.Name = "labelMotorState";
            this.labelMotorState.Size = new System.Drawing.Size(281, 52);
            this.labelMotorState.TabIndex = 12;
            this.labelMotorState.Text = "Unknown";
            this.labelMotorState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rotate Direction:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 557);
            this.Controls.Add(this.tabControlDashboard);
            this.Name = "MainForm";
            this.Text = "Motor Control Demo";
            this.panelConnection.ResumeLayout(false);
            this.panelConnection.PerformLayout();
            this.tabControlDashboard.ResumeLayout(false);
            this.tabConnection.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAcceleration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConnection;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlDashboard;
        private System.Windows.Forms.TabPage tabConnection;
        private System.Windows.Forms.TabPage tabControl;
        private System.Windows.Forms.Label labelAccVal;
        private System.Windows.Forms.Label labelSpeedValMax;
        private System.Windows.Forms.TrackBar trackBarAcceleration;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Timer timerMotorState;
        private System.Windows.Forms.Button btnStopMotor;
        private System.Windows.Forms.Button btnApplySpeed;
        private System.Windows.Forms.RadioButton radioBtnDirectionCCW;
        private System.Windows.Forms.RadioButton radioBtnDirection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.Label labelTargetSpeed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelActualSpeed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSpeedValMin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelSpeedValSet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelMotorState;
        private System.Windows.Forms.Label label2;
    }
}


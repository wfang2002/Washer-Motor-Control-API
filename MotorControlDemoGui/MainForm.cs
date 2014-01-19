using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using WhirlpoolMotorApi;

namespace MotorControlDemoGui
{
    public partial class MainForm : Form
    {
        bool connected = false;

        WPMApi.Direction direction = WPMApi.Direction.CW;

        WPMApi _wpmApi = new WPMApi();

        int targetSpeed;

        public MainForm()
        {
            InitializeComponent();

            string[] Ports = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string port in Ports)
            {
                comboBoxComPort.Items.Add(port);
                if (comboBoxComPort.Text == String.Empty)
                {
                    comboBoxComPort.Text = port;
                }
            }

            ((Control)this.tabControl).Enabled = false;
        }

        private void setTargetSpeed()
        {
            targetSpeed = trackBarSpeed.Value;
            int acceleration = trackBarAcceleration.Value;

            labelTargetSpeed.Text = String.Format("{0:N0}", targetSpeed);
            labelAccVal.Text = String.Format("{0:N0}", acceleration);

            _wpmApi.SetMotorSpeed(targetSpeed, acceleration, direction);

        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            labelSpeedValSet.Text = String.Format("{0:N0}RPM", trackBarSpeed.Value);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string port = comboBoxComPort.Text;

            Console.WriteLine("Selected: {0}", comboBoxComPort.Text);

            connected = _wpmApi.Connect(port);

            if (connected)
            {
                btnConnect.Enabled = false;
                comboBoxComPort.Enabled = false;
                tabControlDashboard.SelectedTab = tabControl;

                ((Control)this.tabConnection).Enabled = false;

                ((Control)this.tabControl).Enabled = true;

            }
        }

        private void btnApplySpeed_Click(object sender, EventArgs e)
        {
            setTargetSpeed();
        }

        private void btnStopMotor_Click(object sender, EventArgs e)
        {
            labelTargetSpeed.Text = "0";

            int acceleration = trackBarAcceleration.Value;

            _wpmApi.StopMotor(acceleration);
        }

        private void radioBtnDirection_CheckedChanged(object sender, EventArgs e)
        {
            direction = radioBtnDirection.Checked ? WPMApi.Direction.CW : WPMApi.Direction.CCW;
        }

        private void timerMotorState_Tick(object sender, EventArgs e)
        {

            //check state
            var state = _wpmApi.State;

            labelMotorState.Text = String.Format("{0}", state);

            switch (state)
            {
                case WPMApi.MotorState.Idle:
                    labelActualSpeed.ForeColor = Color.Green;
                    labelMotorState.ForeColor = Color.Green;
                    break;
                case WPMApi.MotorState.Accelerating:
                    labelActualSpeed.ForeColor = Color.Orange;
                    labelMotorState.ForeColor = Color.Black;
                    break;
                case WPMApi.MotorState.AtTarget:
                    labelActualSpeed.ForeColor = Color.Green;
                    labelMotorState.ForeColor = Color.Black;
                    break;
                case WPMApi.MotorState.Breaking:
                    labelActualSpeed.ForeColor = Color.Red;
                    labelMotorState.ForeColor = Color.Black;
                    break;
                case WPMApi.MotorState.Unknown:
                default:
                    labelActualSpeed.ForeColor = Color.Red;
                    labelMotorState.ForeColor = Color.Red;
                    break;
            }

            radioBtnDirection.Enabled = (state == WPMApi.MotorState.Idle);
            radioBtnDirectionCCW.Enabled = (state == WPMApi.MotorState.Idle);

            btnApplySpeed.Enabled = (state != WPMApi.MotorState.Unknown);


            // check actual speed
            var speed = _wpmApi.Speed;
            labelActualSpeed.Text = String.Format("{0:N0}", speed);
            var delta = Math.Abs(targetSpeed - speed);
        }


    }
}

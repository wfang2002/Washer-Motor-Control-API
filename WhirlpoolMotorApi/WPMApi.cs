using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Collections;

namespace WhirlpoolMotorApi
{
    public class WPMApi
    {
        public enum Direction
        {
            CW = 1, // Clockwise
            CCW = 2 // Counter-Clockwise
        };

        public enum MotorState
        {
            Idle,
            Breaking,
            Accelerating,
            AtTarget,
            Unknown
        };

        private WPMPhy _phyLayer = new WPMPhy();
        private string _errorString;
        private bool _initialized = false;
        private bool _busy = false;
        private Timer _cmdTimer;
        private Queue _cmdQueue;

        private int _speed = 0;
        private MotorState _state = MotorState.Unknown;

        public WPMApi()
        {
            _cmdQueue = new Queue();
        }

        private void OnCmdTimer(object source, ElapsedEventArgs e)
        {
            if (_busy) return;

            if (_cmdQueue.Count > 0)
            {
                _busy = true;

                string cmd = (string)_cmdQueue.Dequeue();

                string resp = _phyLayer.SendReceive(cmd);

                ParseResponse(resp);

                _busy = false;
            }
            else
            {
                if (_initialized)
                {
                    // query motor status if line is not busy
                    QueueCommand("pmc");
                    QueueCommand("pmi");
                }
                else
                {
                    Initialize();
                }
            }
        }

        private void ParseResponse(string response)
        {
            if (response.Length < 4)
            {
                return;
            }

            char cmd = response[2];
            switch (cmd)
            {
                case 'c':   // current state
                    //c - status. 0x00: idle, 0x1a:acc/de-acc to target(L), 0x0a:at target speed(L), 0x18: breaking(L), 
                    //0x15:acc/de-acc t0 target(R), 0x05:at target speed(R), 0x14:breaking(R)
                    var stateHex = response.Substring(5, 2);
                    var stateVal = Convert.ToInt32(stateHex, 16);
                    if (stateVal == 0) _state = MotorState.Idle;
                    else if (stateVal == 0x1A || stateVal == 0x15) _state = MotorState.Accelerating;
                    else if (stateVal == 0x0A || stateVal == 0x05) _state = MotorState.AtTarget;
                    else if (stateVal == 0x18 || stateVal == 0x14) _state = MotorState.Breaking;
                    else _state = MotorState.Unknown;
                    Console.WriteLine("state={0}", _state);
                    break;
                case 'i':   // speed
                    var speedHex = response.Substring(4, 4);
                    _speed = (int)(Convert.ToInt32(speedHex, 16) / 1.2);
                    break;
            }
        }

        private void QueueCommand(string cmd)
        {
            _cmdQueue.Enqueue(cmd);
        }

        public string APIVersion()
        {
            return "WPMApi 0.1";
        }

        public string LastErrorString()
        {
            return _errorString;
        }

        public bool Connect(string port)
        {
            _initialized = false;
            bool connected =  _phyLayer.Connect(port);

            if (connected)
            {
                _cmdTimer = new Timer(500);
                _cmdTimer.Elapsed += new ElapsedEventHandler(OnCmdTimer);
                _cmdTimer.Enabled = true;
            }

            return connected;
        }

        public void Disconnect()
        {
            _cmdQueue.Clear();
            _cmdTimer.Enabled = false;
            _initialized = false;
            _phyLayer.Disconnect();
        }

        public MotorState State
        {
            get { return _state;}
        }

        public int Speed
        {
            get { return _speed; }
        }

        public void Initialize()
        {
            // Send some magic strings to MCU ...
            string cmd = "pmp020887";
            QueueCommand(cmd);

            cmd = "pmp08122d";
            QueueCommand(cmd);

            cmd = "pmp106e50";
            QueueCommand(cmd);

            cmd = "pmp0a5f5a";
            QueueCommand(cmd);

            cmd = "pmp04c828";
            QueueCommand(cmd);

            _initialized = true;
        }

        /// <summary>
        /// Start motor to given RPM
        /// </summary>
        /// <param name="speed">300 - 12000 RPM</param>
        /// <param name="acceleration">64 - 3200</param>
        /// <param name="direction">CCW or CW</param>
        public bool SetMotorSpeed(int speed, int acceleration, Direction direction)
        {
            if (!_initialized)
            {
                _errorString = "Motor not initialized";
                return false;
            }

            string speedHex = String.Format("{0:x4}", (int)(speed*1.2));
            string paramHex = String.Format("{0:x3}", acceleration);

            string dir = direction == Direction.CW ? "r" : "l";
            string cmd = String.Format("pms{2}{0}{1}", speedHex, paramHex, dir);
            QueueCommand(cmd);
            return true;
        }

        /// <summary>
        /// Stop motor
        /// </summary>
        /// <param name="acceleration">64 - 3200</param>
        /// <returns></returns>
        public bool StopMotor(int acceleration)
        {
            if (!_initialized)
            {
                _errorString = "Motor not initialized";
                return false;
            }

            if (acceleration < 64) acceleration = 64;
            if (acceleration > 3200) acceleration = 3200;

            string paramHex = String.Format("{0:x3}", acceleration);

            string cmd = String.Format("pmsb0000{0}", paramHex);
            QueueCommand(cmd);

            return true;
        }
   
    }
}

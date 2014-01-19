using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO.Ports;

namespace WhirlpoolMotorApi
{
    // Physic Layer (UART)
    class WPMPhy
    {
        enum ControlChar : byte
        {
            STX = 0x02,
            ETX = 0x03
        }

        private SerialPort _serialPort = new SerialPort();
        string _errorString;
        private Object rwLock = new Object();

        public string LastErrorString()
        {
            return _errorString;
        }

        public bool Connect(string port)
        {
            Disconnect();

            _serialPort.PortName = port;
            _serialPort.BaudRate = 1200;
            _serialPort.DataBits = 7;
            _serialPort.Parity = Parity.Even;
            _serialPort.StopBits = StopBits.One;

            _serialPort.ReadTimeout = 200;
            _serialPort.WriteTimeout = 200;

            try
            {
                _serialPort.Open();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Open port failed: {0}", e.Message);
                _errorString = e.Message;
                return false;
            }

        }

        // Close connection to SMC100 controller
        public void Disconnect()
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
            }

        }

        public void SetReadTimeout(int timeout)
        {
            _serialPort.ReadTimeout = timeout;
        }

        protected byte CalculateLRC(string msg)
        {
            byte LRC = 0x00;
            for (int i = 0; i < msg.Length; i++)
            {
                //Console.WriteLine("adding {0}", (char)msg[i]);
                LRC = (byte)(LRC ^ (byte)msg[i]);
            }
            return LRC;
        }

        protected byte CalculateLRC(byte[] msg)
        {
            byte LRC = 0x00;
            for (int i = 0; i < msg.Length; i++)
            {
                //Console.WriteLine("adding {0}", (char)msg[i]);
                LRC = (byte)(LRC ^ (byte)msg[i]);
            }
            return LRC;
        }

        // Sync call - Send a command to controller and wait for response
        public string SendReceive(string cmd)
        {
            if (!_serialPort.IsOpen)
            {
                _errorString = "Port is not open.";
                return "";
            }

            lock (rwLock)
            {
                //cleanup buffer before writing
                if (_serialPort.BytesToRead > 0)
                {
                    _serialPort.ReadExisting();
                }

                byte lrcCal = CalculateLRC(cmd + (char)ControlChar.ETX);

                _serialPort.Write((char)ControlChar.STX + cmd + (char)ControlChar.ETX + (char)lrcCal);
                Console.WriteLine("-> {0}", cmd);

                Receive();

                return Receive();
            }

        }

        //Send command to controller, not wait for response
        public bool Send(string cmd)
        {
            if (!_serialPort.IsOpen)
            {
                _errorString = "Port is not open.";
                return false;
            }

            lock (rwLock)
            {
                //cleanup buffer before writing
                if (_serialPort.BytesToRead > 0)
                {
                    _serialPort.ReadExisting();
                }

                byte lrcCal = CalculateLRC(cmd + (char)ControlChar.ETX);

                _serialPort.Write((char)ControlChar.STX + cmd + (char)ControlChar.ETX + (char)lrcCal);
                //Console.WriteLine("-> {0}", cmd);                
            }

            return true;

        }

        public string Receive()
        {
            try
            {
                string message = "";

                // Wait till we get STX
                while (_serialPort.ReadByte() != (byte)ControlChar.STX) ;

                byte recv = 0;
                do
                {
                    recv = (byte)_serialPort.ReadByte();
                    message += (char)recv;

                } while (recv != (byte)ControlChar.ETX);

                byte lrcRecv = (byte)_serialPort.ReadByte();
                byte lrcCal = CalculateLRC(message);


                if (lrcCal != lrcRecv)
                {
                    _errorString = "Error: Wrong LRC";
                    return "";
                }

                message = message.Substring(0, message.Length - 1);
                Console.WriteLine("<- {0}", message);
                return message;

            }
            catch (TimeoutException e)
            {
                //Console.WriteLine("<-[Exception] {0}", e.Message);
                _errorString = e.Message;
                return "";
            }
        }
    }
}

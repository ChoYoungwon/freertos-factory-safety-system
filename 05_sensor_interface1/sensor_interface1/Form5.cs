using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace sensor_interface1
{
    public partial class Form5 : Form
    {
        int playerspeed = 30;
        bool goLeft, goRight, goUp, goDown;
        private SerialPort serialPort1 = new SerialPort();

        public Form5()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (goLeft)
            {
                player.Left -= playerspeed;
            }
            if (goRight)
            {
                player.Left += playerspeed;
            }
            if (goUp)
            {
                player.Top -= playerspeed;
            }
            if (goDown)
            {
                player.Top += playerspeed;
            }
        }

        private void Form5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
        }

        private void Form5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = SerialPort.GetPortNames()[0];
                serialPort1.BaudRate = 9600;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Parity = Parity.None;

                serialPort1.DtrEnable = true;
                serialPort1.RtsEnable = true;

                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);

                try
                {
                    serialPort1.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("시리얼 포트를 열 수 없습니다.: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    serialPort1.DataReceived -= new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                }

            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string rxd = "";
            int direction = 0;
            try
            {
                rxd = serialPort1.ReadLine();
                direction = int.Parse(rxd);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("시리얼 포트 읽기 오류 : " + ex.Message);
                return;
            }

            this.Invoke(new Action(() =>
            {
                switch (direction)
                {
                    case 1:
                        player.Top -= playerspeed;
                        break;
                    case 2:
                        player.Top += playerspeed;
                        break;
                    case 3:
                        player.Left -= playerspeed;
                        break;
                    case 4:
                        player.Left += playerspeed;
                        break;
                    default:
                        break;
                }

            }));
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                // 이벤트 핸들러 연결 해제 (중요!)
                serialPort1.DataReceived -= new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                serialPort1.Close();
                serialPort1.Dispose(); // SerialPort 객체 리소스 해제
            }
        }
    }
}

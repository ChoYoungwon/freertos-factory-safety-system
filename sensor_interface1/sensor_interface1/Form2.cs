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

namespace sensor_interface1
{
    public partial class Form2 : Form
    {
        protected SerialPort serialPort1 = new SerialPort();
        public Form2()
        {
            InitializeComponent();
        }

        protected void Form2_Load(object sender, EventArgs e)
        {
            cbx_ports.DataSource = SerialPort.GetPortNames();
            tbx_comState.ForeColor = Color.Red;
            tbx_comState.Text = "Disconnected";
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = cbx_ports.Text;
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
                    cbx_ports.Enabled = false;
                    tbx_comState.ForeColor = Color.Green;
                    tbx_comState.Text = "Connected";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("시리얼 포트를 열 수 없습니다.: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    serialPort1.DataReceived -= new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                }

            }
            else
            {
                tbx_comState.ForeColor = Color.Green;
                tbx_comState.Text = "Connected!";
            }
        }

        protected virtual void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string rxd = serialPort1.ReadLine();
            this.Invoke(new Action(() =>
            {
                tbx_receiveData.AppendText(rxd + "\r\n");
            }));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                cbx_ports.Enabled = true;
                tbx_comState.ForeColor = Color.Red;
                tbx_comState.Text = "Disconnected";
            }
            else
            {
                cbx_ports.Enabled = true;
                tbx_comState.ForeColor = Color.Red;
                tbx_comState.Text = "Disconnected";
            }
        }
        protected void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                // 이벤트 핸들러 연결 해제 (중요!)
                serialPort1.DataReceived -= new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                serialPort1.Close();
                serialPort1.Dispose(); // SerialPort 객체 리소스 해제
            }
        }
    }
}

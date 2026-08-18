using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace sensor_interface1
{
    public partial class Form6 : Form4
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Form2_Load(sender, e);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int brightness = trackBar1.Value;
            int baseR = 255;
            int baseG = 255;
            int baseB = 0;
            int r = (baseR * brightness) / 255;
            int g = (baseG * brightness) / 255;
            int b = (baseB * brightness) / 255;
            lbl_bright.BackColor = Color.FromArgb(r, g, b);
        }

        protected override void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string rxd = serialPort1.ReadLine();
            this.Invoke(new Action(() =>
            {
                tbx_receiveData.AppendText(rxd + "\r\n");
                trackBar1.Value = 255 - int.Parse(rxd);
            }));
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form4_FormClosing(sender, e);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            int brightness = trackBar1.Value; // 0~255
            int baseR = 255;
            int baseG = 255;
            int baseB = 0;
            int r = (baseR * brightness) / 255;
            int g = (baseG * brightness) / 255;
            int b = (baseB * brightness) / 255;
            lbl_bright.BackColor = Color.FromArgb(r, g, b);
        }
    }
}

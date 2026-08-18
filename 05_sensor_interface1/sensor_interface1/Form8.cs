using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sensor_interface1
{
    public partial class Form8 : Form7
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btn_timer_Click(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(tbx_interval.Text);
            timer1.Start();
            //pictureBox1.Image = Properties.Resources.fan_gif_10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String sendData = tbx_data.Text + '\n';
            Debug.WriteLine(sendData);
            serialPort1.Write(sendData);
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            //pictureBox1.Image = Properties.Resources.coolingFan_PNG;
        }
    }
}

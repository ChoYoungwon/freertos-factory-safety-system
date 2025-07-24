using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = $"{DateTime.Now:HH:MM:ss}";
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;

            if (timer1.Enabled)
            {
                btnStartStop.Text = "정 지";
            }
            else
            {
                btnStartStop.Text = "시 작";
            }
        }
    }
}

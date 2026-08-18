using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sensor_interface1
{
    public partial class Form4 : Form2
    {
        int color_num = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Form2_Load(sender, e);
        }

        private void btn_changeLed_Click(object sender, EventArgs e)
        {
            color_num = (++color_num) % 4;
            string strColor = color_num.ToString();
            this.serialPort1.Write(strColor);
            Chage_textColor();
        }

        private void Chage_textColor()
        {
            switch (color_num)
            {
                case 0:
                    tbx_color.ForeColor = Color.Black;
                    tbx_color.Text = "OFF";
                    break;
                case 1:
                    tbx_color.ForeColor = Color.Red;
                    tbx_color.Text = "Red";
                    break;
                case 2:
                    tbx_color.ForeColor = Color.Green;
                    tbx_color.Text = "Green";
                    break;
                case 3:
                    tbx_color.ForeColor = Color.Blue;
                    tbx_color.Text = "Blue";
                    break;
            }
        }

        protected void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2_FormClosing(sender, e);
        }
    }
}

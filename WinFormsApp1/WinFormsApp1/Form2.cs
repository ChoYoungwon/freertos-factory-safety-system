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
    public partial class Form2 : Form
    {
        private int count = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.count == 0)
            {
                button1.BackColor = Color.YellowGreen;
            }
            else
            {
                button1.BackColor = Color.Blue;
            }
            this.count = (++this.count) % 2;
            button1.Text = "Processing...";
        }
    }
}

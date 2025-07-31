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
    public partial class Form7 : Form3
    {
        public Form7()
        {
            InitializeComponent();
        }

        protected override void btn_send_Click(object sender, EventArgs e)
        {
            string sendData = tbx_data.Text + '\n';
            Debug.WriteLine("overiding됨 " + sendData);
            serialPort1.Write(sendData);
        }
    }
}

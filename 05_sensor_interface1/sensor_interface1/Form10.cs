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
using System.Diagnostics;

namespace sensor_interface1
{
    public partial class Form10 : Form2
    {
        bool check = false;

        public Form10()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            check = true;
        }

        protected override void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string rxd = serialPort1.ReadLine();
            int rData = 0;
            this.Invoke(new Action(() =>
            {
                tbx_receiveData.AppendText(rxd + "\r\n");
                Debug.WriteLine(rxd + "\r\n");
                if (check)
                {
                    rData = int.Parse(rxd);
                    aGauge1.Value = rData;
                }
            }));
        }
    }
}

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
using System.Windows.Forms.DataVisualization.Charting;

namespace sensor_interface1
{
    public partial class Form11 : Form2
    {
        int maxPoints = 10;
        int timerCount = 0;

        public Form11()
        {
            InitializeComponent();
        }

        protected override void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string rxd = serialPort1.ReadLine();
            string[] splitData = rxd.Split(',');
            string temp = splitData[0];
            string humi = splitData[1];
            int tempData = int.Parse(temp.Trim());
            int humiData = int.Parse(humi.Trim());
            this.Invoke(new Action(() => {
                tbx_receiveData.AppendText(rxd + "\r\n");
                ChartAddData(tempData, humiData);
            }));
        }

        private void ChartAddData(int data1, int data2)
        {
            chart1.Series["Series1"].Points.AddXY(timerCount, data1);
            chart1.Series["Series2"].Points.AddXY(timerCount, data2);
            if (chart1.Series["Series1"].Points.Count > maxPoints)
            {
                chart1.Series["Series1"].Points.RemoveAt(0);
            }
            if (chart1.Series["Series2"].Points.Count > maxPoints)
            {
                chart1.Series["Series2"].Points.RemoveAt(0);
            }

            chart1.ChartAreas[0].AxisX.Minimum = chart1.Series["Series1"].Points[0].XValue;
            chart1.ChartAreas[0].AxisX.Maximum = chart1.Series["Series1"].Points[chart1.Series["Series1"].Points.Count - 1].XValue;

            chart1.ChartAreas[0].AxisX.Minimum = chart1.Series["Series2"].Points[0].XValue;
            chart1.ChartAreas[0].AxisX.Maximum = chart1.Series["Series2"].Points[chart1.Series["Series2"].Points.Count - 1].XValue;
            timerCount++;
        }
    }
}

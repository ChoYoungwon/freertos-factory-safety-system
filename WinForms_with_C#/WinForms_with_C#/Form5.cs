using MySql.Data.MySqlClient; 
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
using System.Windows.Forms.DataVisualization.Charting;

namespace WinForms_with_C_
{
    public partial class Form5 : Form
    {
        MySqlConnection conn = null;
        private object randomValue1;
        private object randomValue2;
        private int timerCount = 0;
        Random random = new Random();
        int maxPoints = 10;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            DBconn db = new DBconn("localhost", 3306, "madangdb", "madang", "madang");
            conn = db.SetConnection();
            chartA.Series["Series1"].ChartType = SeriesChartType.SplineArea;
            chartA.Series["Series2"].ChartType = SeriesChartType.Line;
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            randomValue1 = random.Next(0, 100);
            randomValue2 = random.Next(0, 100);
            chartA.Series["Series1"].Points.AddXY(timerCount, randomValue1);
            if (chartA.Series["Series1"].Points.Count > maxPoints)
            {
                chartA.Series["Series1"].Points.RemoveAt(0);
            }
            chartA.ChartAreas[0].AxisX.Minimum = chartA.Series["Series1"].Points[0].XValue;
            chartA.ChartAreas[0].AxisX.Maximum = chartA.Series["Series1"].Points[chartA.Series["Series1"].Points.Count - 1].XValue;

            chartA.Series["Series2"].Points.AddXY(timerCount, randomValue2);
            if (chartA.Series["Series2"].Points.Count > maxPoints)
            {
                chartA.Series["Series2"].Points.RemoveAt(0);
            }
            chartA.ChartAreas[0].AxisX.Minimum = chartA.Series["Series2"].Points[0].XValue;
            chartA.ChartAreas[0].AxisX.Maximum = chartA.Series["Series2"].Points[chartA.Series["Series2"].Points.Count - 1].XValue;
            // 타이머 중지 조건
            if (++timerCount == 100)
            {
                timer1.Stop();
                timer2.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                string sendTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string query = $"insert into chartdata(value1,value2,sendTime) values ({randomValue1},{randomValue2},'{sendTime}')";
                Console.WriteLine(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("Failed to insert data.");
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine($"Error : {ex}");
            }
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            timer2.Stop();

            if (conn != null)
            {
                try
                {
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error closing connection: {ex.Message}");
                }
            }
        }
    }
}

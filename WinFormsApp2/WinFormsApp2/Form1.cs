using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;

        private int timerCount = 0;
        Random random = new Random();
        int randomValue;
        int maxPoints = 10;

        public Form1()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
        }

        private void btnAddY_Click(object sender, EventArgs e)
        {
            chartA.Series["Series1"].Points.Clear();
            chartA.Series["Series1"].Points.Add(100);   // X=1
            chartA.Series["Series1"].Points.Add(200);
            chartA.Series["Series1"].Points.Add(300);
            chartA.Series["Series1"].Points.Add(400);
        }

        private void btnAddXY_Click(object sender, EventArgs e)
        {
            chartB.Series["Series1"].Points.Clear();
            chartB.Series["Series1"].Points.AddXY(10, 100);
            chartB.Series["Series1"].Points.AddXY(20, 200);
            chartB.Series["Series1"].Points.AddXY(30, 300);
            chartB.Series["Series1"].Points.AddXY(40, 400);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series1"].Points.AddXY(1, 100);
            chart1.Series["Series1"].Points.AddXY(2, 200);
            chart1.Series["Series1"].Points.AddXY(3, 300);
            chart1.Series["Series1"].Points.AddXY(4, 400);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            chart2.Series["Series1"].Points.Clear();
            chart2.Series["Series1"].Points.AddXY("사과", 100);
            chart2.Series["Series1"].Points.AddXY("복숭아", 200);
            chart2.Series["Series1"].Points.AddXY("수박", 300);
            chart2.Series["Series1"].Points.AddXY("멜론", 400);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chartA.Series["Series1"].ChartType = SeriesChartType.SplineArea;
            timer.Start();
        }

        // 실시간 랜덤 값 생성, 차트 표현
        private void timer1_Tick(object sender, EventArgs e)
        {
            randomValue = random.Next(0, 100);
            chartA.Series["Series1"].Points.AddXY(timerCount, randomValue);
            if (chartA.Series["Series1"].Points.Count > maxPoints)
            {
                chartA.Series["Series1"].Points.RemoveAt(0);
            }
            chartA.ChartAreas[0].AxisX.Minimum = chartA.Series["Series1"].Points[0].XValue;
            chartA.ChartAreas[0].AxisX.Maximum = chartA.Series["Series1"].Points[chartA.Series["Series1"].Points.Count - 1].XValue;
            // 타이머 중지 조건
            if (++timerCount == 100)
            {
                timer.Stop();
            }
        }
    }
}
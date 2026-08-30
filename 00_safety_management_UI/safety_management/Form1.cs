using System.IO.Ports;
using System.Text.RegularExpressions;

namespace safety_management
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort1 = new SerialPort();
        private int timerCount = 0;
        private int maxPoints = 6;
        private bool stop_state = false;
        private bool flame_state = false;

        private readonly string warningImagePath = @"..\images\fire_warning.png";
        private readonly string normalImagePath = @"..\images\normal.png";
        private readonly string prohibitionImagePath = @"..\images\prohibition.png";

        private Image WarningImage;
        private Image normalImage;
        private Image prohibitionImage;

        private CancellationTokenSource cts;    // 전용 읽기 스레드

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cbx_ports.DataSource = SerialPort.GetPortNames();
                tbx_comState.ForeColor = Color.Red;
                tbx_comState.Text = "Disconnected";

                WarningImage = Image.FromFile(warningImagePath);
                normalImage = Image.FromFile(normalImagePath);
                prohibitionImage = Image.FromFile(prohibitionImagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Form1 초기 연결 실패: {ex.Message}\n\n{ex.StackTrace}", "Form1 초기 연결 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = cbx_ports.Text;
                serialPort1.BaudRate = 115200;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Parity = Parity.None;

                serialPort1.DtrEnable = true;
                serialPort1.RtsEnable = true;

                //serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);

                try
                {
                    serialPort1.Open();
                    cbx_ports.Enabled = false;
                    tbx_comState.ForeColor = Color.Green;
                    tbx_comState.Text = "Connected";

                    // 전용 읽기 스레드 시작
                    cts = new CancellationTokenSource();
                    Task.Run(() => ReadSerialDataLoop(cts.Token));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("시리얼 포트를 열 수 없습니다.: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //serialPort1.DataReceived -= new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                }

            }
            else
            {
                tbx_comState.ForeColor = Color.Green;
                tbx_comState.Text = "Connected!";
            }
        }

        // 전용 읽기 스레드
        private void ReadSerialDataLoop(CancellationToken token)
        {
            while (!token.IsCancellationRequested && serialPort1.IsOpen)
            {
                try
                {
                    // ReadLine()은 개행문자를 만날 때까지 스레드를 차단
                    string rxd = serialPort1.ReadLine().Trim();
                    // 읽은 데이터 처리를 별도 메서드에 위임
                    ProcessReceivedData(rxd);
                }
                catch (TimeoutException) { } // ReadTimeout 발생 시 아무것도 하지 않고 계속 진행
                catch (Exception)
                {
                    // 포트가 닫히거나 다른 오류 발생 시 루프 종료
                    break;
                }
            }
        }

        // 읽은 데이터를 처리하는 로직
        private void ProcessReceivedData(string rxd)
        {
            // emergency_stop 메시지 처리
            if (rxd == "emergency_stop" && stop_state == false)
            {
                this.BeginInvoke(new Action(() =>
                {
                    stop_state = true;
                    pictureBox2.Image = prohibitionImage;
                    txb_recieve.AppendText(rxd + "\r\n");
                }));
                return;
            }

            if (rxd == "flame" && flame_state == false)
            {
                //serialPort1.Write("stop");
                this.BeginInvoke(new Action(() =>
                {
                    flame_state = true;
                    //stop_state = true;
                    pictureBox1.Image = WarningImage;
                    //pictureBox2.Image = prohibitionImage;
                    txb_recieve.AppendText(rxd + "\r\n");
                }));
                return;
            }
            else if (rxd == "noflame")
            {
                this.BeginInvoke(new Action(() =>
                {
                    flame_state = false;
                    pictureBox1.Image = normalImage;
                    txb_recieve.AppendText(rxd + "\r\n");
                }));
                return;
            }

            // 온습도 데이터 처리
            var match = Regex.Match(rxd, @"^(\d+(?:\.\d+)?)\s*,\s*(\d+(?:\.\d+)?)$");
            if (match.Success)
            {
                string[] splitData = rxd.Split(',');
                float humiData = float.Parse(splitData[0]);
                float tempData = float.Parse(splitData[1]);
                this.BeginInvoke(new Action(() =>
                {
                    txb_recieve.AppendText(rxd + "\r\n");
                    ChartAddData(humiData, tempData);
                    lbl_humi.Text = humiData.ToString() + "(%)";
                    lbl_temp.Text = tempData.ToString() + "(℃)";
                }));
            }
            else
            {
                // 그외 모든 메시지
                this.BeginInvoke(new Action(() =>
                {
                    txb_recieve.AppendText(rxd + "\r\n");
                }));
            }
        }

        private void ChartAddData(float humi, float temp)
        {
            chart1.Series["Temperature"].Points.AddXY(timerCount, temp);
            chart2.Series["humidity"].Points.AddXY(timerCount, humi);
            if (chart1.Series["Temperature"].Points.Count > maxPoints)
            {
                chart1.Series["Temperature"].Points.RemoveAt(0);
            }
            if (chart2.Series["humidity"].Points.Count > maxPoints)
            {
                chart2.Series["humidity"].Points.RemoveAt(0);
            }

            chart1.ChartAreas[0].AxisX.Minimum = chart1.Series["Temperature"].Points[0].XValue;
            chart1.ChartAreas[0].AxisX.Maximum = chart1.Series["Temperature"].Points[chart1.Series["Temperature"].Points.Count - 1].XValue;

            chart2.ChartAreas[0].AxisX.Minimum = chart2.Series["humidity"].Points[0].XValue;
            chart2.ChartAreas[0].AxisX.Maximum = chart2.Series["humidity"].Points[chart2.Series["humidity"].Points.Count - 1].XValue;
            timerCount++;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                cbx_ports.Enabled = true;
                tbx_comState.ForeColor = Color.Red;
                tbx_comState.Text = "Disconnected";
            }
            else
            {
                cbx_ports.Enabled = true;
                tbx_comState.ForeColor = Color.Red;
                tbx_comState.Text = "Disconnected";
            }

            if (cts != null)
            {
                cts.Cancel();
                cts = null;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                // 이벤트 핸들러 연결 해제 (중요!)
                //serialPort1.DataReceived -= new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                serialPort1.Close();
                serialPort1.Dispose(); // SerialPort 객체 리소스 해제
            }

            if (cts != null)
            {
                cts.Cancel();
                cts = null;
            }
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            if (stop_state == true)
            {
                this.BeginInvoke(new Action(() =>
                {
                    stop_state = false;
                    pictureBox2.Image = normalImage;
                    serialPort1.Write("recover");
                }));
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            serialPort1.Write("stop");
            this.BeginInvoke(new Action(() =>
            {
                stop_state = true;

                pictureBox2.Image = prohibitionImage;
            }));
        }

        private void cbx_ports_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

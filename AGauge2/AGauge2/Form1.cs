namespace AGauge2
{
    public partial class Form1 : Form
    {
        int colorNum = 0;
        float currentAngle = 0;
        float centerX = 0;
        float centerY = 0;
        Image masterImage;
        private bool timerOn;
        private int timerCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // 게이지 증가 버튼 클릭 이벤트
        private void button1_Click(object sender, EventArgs e)
        {
            aGauge1.Value += 5;
            if (aGauge1.Value > 80)
            {
                colorNum = 3;
            }
            else if (aGauge1.Value > 60)
            {
                colorNum = 2;
            }
            else if (aGauge1.Value > 20)
            {
                colorNum = 1;
            }
            else
            {
                colorNum = 0;
            }
            changeColor(colorNum);
        }

        // 게이지 감소 버튼 클릭 이벤트
        private void button2_Click(object sender, EventArgs e)
        {
            aGauge1.Value -= 5;
            if (aGauge1.Value > 80)
            {
                colorNum = 3;
            }
            else if (aGauge1.Value > 60)
            {
                colorNum = 2;
            }
            else if (aGauge1.Value > 20)
            {
                colorNum = 1;
            }
            else
            {
                colorNum = 0;
            }
            changeColor(colorNum);
        }

        private void changeColor(int colorNum)
        {
            switch (colorNum)
            {
                case 0:
                    circularButton1.BackColor = Color.White;
                    circularButton1.FlatAppearance.BorderColor = Color.White;
                    circularButton1.Text = "Ready";
                    break;
                case 1:
                    circularButton1.BackColor = Color.Lime;
                    circularButton1.FlatAppearance.BorderColor = Color.Lime;
                    circularButton1.Text = "Run";
                    break;
                case 2:
                    circularButton1.BackColor = Color.Yellow;
                    circularButton1.FlatAppearance.BorderColor = Color.Yellow;
                    circularButton1.Text = "Warning";
                    break;
                case 3:
                    circularButton1.BackColor = Color.Red;
                    circularButton1.FlatAppearance.BorderColor = Color.White;
                    circularButton1.Text = "Danger";
                    break;
                default:
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            masterImage = pictureBox1.Image;
            Bitmap bitmap = new Bitmap(masterImage.Width, masterImage.Height);
            currentAngle += 1;
            if (currentAngle >= 360)
            {
                currentAngle = 0;
            }
            bitmap.SetResolution(masterImage.HorizontalResolution, masterImage.VerticalResolution);

            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.TranslateTransform(centerX, centerY);      //센터로 피벗을 옮겨줍니다.
            graphics.RotateTransform(currentAngle);             //센터를 중심으로 돌려줍니다.
            graphics.TranslateTransform(-centerX, -centerY);    //다시 피벗을 원위치 시켜줍니다.
            graphics.DrawImage(masterImage, PointF.Empty);      //bitmap에 masterImage를 0,0 기준으로 그려줍니다.

            pictureBox1.Image = bitmap;
        }

        private void btnTurn_Click(object sender, EventArgs e)
        {
            masterImage = pictureBox1.Image;
            centerX = masterImage.Width / 2;
            centerY = masterImage.Height / 2;
            if (timerOn)
            {
                timer1.Stop();
                timerOn = false;
            }
            else
            {
                timer1.Start();
                timerOn = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 디폴트값 사용 (Maximum=100, Minimum = 0, Step=10)
            progressBar1.Style = ProgressBarStyle.Blocks;

            // 최대, 최소, 간격을 임의로 조정
            progressBar2.Style = ProgressBarStyle.Continuous;
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 10;
            progressBar2.Step = 5;
            progressBar2.Value = 0;

            // Marquee 스타일
            progressBar3.Style = ProgressBarStyle.Marquee;
            progressBar3.Enabled = true;

            // 테스트를 위해 타이머 시작
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // 한 스텝 이동
            progressBar1.PerformStep();
            progressBar2.PerformStep();

            // 타이머 중지 조건
            if (++timerCount == 10)
            {
                timer.Stop();
                progressBar3.Enabled = false;
            }
        }
    }
}

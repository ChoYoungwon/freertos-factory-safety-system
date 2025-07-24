using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 폼 사용 전 초기화 작업(Load 이벤트) 
        // object : 이벤트가 발생한 컨트롤(객체), EventArgs : 이벤트에 대한 정보
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("안녕하세요.");
            sb.AppendLine("멀티라인 테스트");

            textBox2.Text = sb.ToString();
            textBox2.Focus();
        }

        // 폼 종료 시 종료 작업(FormClosed 이벤트)
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // 폼 닫기 버튼 클릭 시 확인 메시지 표시(FormClosing 이벤트)
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료할까요?", "확인",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        // Button Control
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        // CheckBox Control
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        // Timer Control
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
        }

        //DataGridView Control
        private void DataGridView_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            Form6 newForm = new Form6();
            newForm.Show();
        }
    }
}

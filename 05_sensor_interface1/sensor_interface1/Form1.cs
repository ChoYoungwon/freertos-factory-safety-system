using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace sensor_interface1
{
    public partial class Form1 : Form
    {
        SerialPort port = new SerialPort("COM5", 9600);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            port.Open();
            port.Write("1");
            port.Close();
        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
            port.Open();
            port.Write("2");
            port.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            port.Close();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btn_LCD_Click(object sender, EventArgs e)
        {
            port.Close();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btnRGB_Click(object sender, EventArgs e)
        {
            port.Close();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void btn_joystic_Click(object sender, EventArgs e)
        {
            port.Close();
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void btnPhotoresistor_Click(object sender, EventArgs e)
        {
            port.Close();
            Form6 form6 = new Form6();
            form6.Show();
        }
        private void btnMotor_Click(object sender, EventArgs e)
        {
            port.Close();
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void btnStepping_Click(object sender, EventArgs e)
        {
            port.Close();
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void btnBuzzer_Click(object sender, EventArgs e)
        {
            port.Close();
            Form9 form9 = new Form9();
            form9.Show();
        }

        private void btn_variable_Click(object sender, EventArgs e)
        {
            port.Close();
            Form10 form10 = new Form10();
            form10.Show();
        }

        private void btnTemperature_Click(object sender, EventArgs e)
        {
            port.Close();
            Form11 form11 = new Form11();
            form11.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            port.Close();
        }
    }
}

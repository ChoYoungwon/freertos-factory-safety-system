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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "Id");
            dataGridView1.Columns.Add("Name", "이름");
            dataGridView1.Columns.Add("Grade", "학년");
            dataGridView1.Columns.Add("Date", "날짜");
            dataGridView1.Columns.Add("Amount", "금액");
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            StreamReader rd = new StreamReader("data.txt");

            while(!rd.EndOfStream)
            {
                string line = rd.ReadLine();
                string[] cols = line.Split(',');

                dataGridView1.Rows.Add(cols[0], cols[1], cols[2], cols[3], cols[4]);
            }

            rd.Close();
        }
    }
}

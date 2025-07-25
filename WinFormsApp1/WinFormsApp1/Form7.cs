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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            string[] grade = { "1th", "2th", "3th", "4th", "5th", "6th", "7th", "8th", "9th", "10th" };
            string[] amount = { "$5", "$10", "$15", "$20", "$25", "$30", "$35", "$40", "$45", "$50" };
            cmbGrade.Items.AddRange(grade);
            cmbGrade.SelectedIndex = 0;
            cmbAmount.Items.AddRange(amount);
            cmbAmount.SelectedIndex = 0;
        }

        // Save 클릭시
        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtStudentID.Text;
            string name = txtStudentName.Text;

            string grade = "";
            if (cmbGrade.SelectedIndex >= 0)
            {
                grade = cmbGrade.Items[cmbGrade.SelectedIndex].ToString();
            }

            string date = dtDate.Value.ToShortDateString();

            string amount = "";
            if (cmbAmount.SelectedIndex >= 0)
            {
                amount = cmbAmount.Items[cmbAmount.SelectedIndex].ToString();
            }

            // 각 필드 연결
            string data = id + "," + name + "," + grade + "," + date + "," + amount;

            // 텍스트 파일을 쓸 때 StreamWriter를 사용한다.
            StreamWriter wr = new StreamWriter("data.txt", true);
            wr.WriteLine(data);
            wr.Close();
            MessageBox.Show("저장되었습니다.");
        }

        // Clear 클릭시
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentID.Text = string.Empty;
            txtStudentName.Text = string.Empty;
            cmbGrade.SelectedIndex = -1;
            cmbAmount.SelectedIndex = -1;
            dtDate.Value = DateTime.Now;
        }
    }
}

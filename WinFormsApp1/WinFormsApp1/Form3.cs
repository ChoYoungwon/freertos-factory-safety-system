using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        enum Meat
        {
            등심,
            안심,
            갈비
        }

        private Meat _selectedMeat;
        public Form3()
        {
            InitializeComponent();
        }

        public class Dept
        {
            public string DeptCode { get; set; }
            public string DeptName { get; set; }
        }

        List<Dept> deptList = new List<Dept>();

        private void Form3_Load(object sender, EventArgs e)
        {
            // listBox 초기화
            deptList.Add(new Dept { DeptCode = "D01", DeptName = "총무팀" });
            deptList.Add(new Dept { DeptCode = "D02", DeptName = "전산팀" });
            deptList.Add(new Dept { DeptCode = "D03", DeptName = "영업팀" });
            deptList.Add(new Dept { DeptCode = "D04", DeptName = "생산팀" });
            deptList.Add(new Dept { DeptCode = "D05", DeptName = "홍보팀" });

            lstDept.DisplayMember = "DeptName";
            lstDept.ValueMember = "DeptCode";
            lstDept.DataSource = deptList;

            lstDept.SelectedIndex = 0;  // 첫번째 항목을 선택

            // combobox 초기화
            string[] data = { "사과", "토마토", "포도", "배", "복숭아" };
            comboSimple.Items.AddRange(data);
            comboDropDown.Items.AddRange(data);
            comboDropDownList.Items.AddRange(data);

            comboSimple.SelectedIndex = 0;  // 첫번째 항목을 선택
            comboDropDown.SelectedIndex = 0;  // 첫번째 항목을 선택
            comboDropDownList.SelectedIndex = 0;  // 첫번째 항목을 선택 
        }

        // 선택항목 보기(CheckBox Control)
        private void button1_Click(object sender, EventArgs e)
        {
            string receiveMethod = "";

            if (chkEmail.Checked)
                receiveMethod += $"{chkEmail.Text}";
            else if (chkSMS.Checked)
                receiveMethod += $"{chkSMS.Text}";

            string topic = "";
            foreach (var controls in grpTopic.Controls)
            {
                var checkBox = controls as CheckBox;

                if (checkBox != null && checkBox.Checked)
                {
                    topic += $"{checkBox.Text}, ";
                }
            }

            MessageBox.Show($"수신방법 : {receiveMethod}\n주제: {topic}");

        }

        // RadioButton Control
        private void radioButton1_Click(object sender, EventArgs e)
        {
            this._selectedMeat = Meat.등심;
            DisplayMenu();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            this._selectedMeat = Meat.안심;
            DisplayMenu();
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            this._selectedMeat = Meat.갈비;
            DisplayMenu();
        }

        private void DisplayMenu()
        {
            lblMsg.Text = string.Format("선택한 메뉴 : {0}", this._selectedMeat.ToString());
            lblMsg.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"선택한 부서코드: {lstDept.SelectedValue}\n선택한 부서명: {lstDept.Text}");
        }
    }
}

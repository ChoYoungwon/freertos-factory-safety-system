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
    public partial class Form6 : Form
    {
        private string CurrentString = "0";
        private double cumulativeResult = 0;
        private bool initial = true;
        private bool isDot = false;
        private int calcurationCount = 1;
        private String operation = "";

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    cumulativeResult += double.Parse(CurrentString);
                    display.Text = cumulativeResult.ToString();
                    break;
                case "-":
                    cumulativeResult -= double.Parse(CurrentString);
                    display.Text = cumulativeResult.ToString();
                    break;
                case "*":
                    cumulativeResult *= double.Parse(CurrentString);
                    display.Text = cumulativeResult.ToString();
                    break;
                case "/":
                    if (double.Parse(CurrentString) != 0)
                    {
                        cumulativeResult /= double.Parse(CurrentString);
                        display.Text = cumulativeResult.ToString();
                    }
                    else
                        MessageBox.Show("0으로 나눌 수 없습니다.");
                    break;
            }
            calcurationCount = 1;
            CurrentString = cumulativeResult.ToString();
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            if (calcurationCount++ == 1)
                cumulativeResult = double.Parse(CurrentString);
            else
            {
                switch (operation)
                {
                    case "+":
                        cumulativeResult += double.Parse(CurrentString);
                        display.Text = cumulativeResult.ToString();
                        break;
                    case "-":
                        cumulativeResult -= double.Parse(CurrentString);
                        display.Text = cumulativeResult.ToString();
                        break;
                    case "*":
                        cumulativeResult *= double.Parse(CurrentString);
                        display.Text = cumulativeResult.ToString();
                        break;
                    case "/":
                        if (double.Parse(CurrentString) != 0)
                        {
                            cumulativeResult /= double.Parse(CurrentString);
                            display.Text = cumulativeResult.ToString();
                        }
                        else
                            MessageBox.Show("0으로 나눌 수 없습니다.");
                        break;
                }
            }
            operation = "+";
            initial = true;
            isDot = false;
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            if (calcurationCount++ == 1)
                cumulativeResult = double.Parse(CurrentString);
            else
            {
                switch (operation)
                {
                    case "+":
                        cumulativeResult += double.Parse(CurrentString);
                        display.Text = cumulativeResult.ToString();
                        break;
                    case "-":
                        cumulativeResult -= double.Parse(CurrentString);
                        display.Text = cumulativeResult.ToString();
                        break;
                    case "*":
                        cumulativeResult *= double.Parse(CurrentString);
                        display.Text = cumulativeResult.ToString();
                        break;
                    case "/":
                        if (double.Parse(CurrentString) != 0)
                        {
                            cumulativeResult /= double.Parse(CurrentString);
                            display.Text = cumulativeResult.ToString();
                        }
                        else
                            MessageBox.Show("0으로 나눌 수 없습니다.");
                        break;
                }
            }
            operation = "-";
            initial = true;
            isDot = false;
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            if (calcurationCount++ == 1)
                cumulativeResult = double.Parse(CurrentString);
            else
            {
                switch (operation)
                {
                    case "+":
                        cumulativeResult += double.Parse(CurrentString);
                        display.Text = cumulativeResult.ToString();
                        break;
                    case "-":
                        cumulativeResult -= double.Parse(CurrentString);
                        display.Text = cumulativeResult.ToString();
                        break;
                    case "*":
                        cumulativeResult *= double.Parse(CurrentString);
                        display.Text = cumulativeResult.ToString();
                        break;
                    case "/":
                        if (double.Parse(CurrentString) != 0)
                        {
                            cumulativeResult /= double.Parse(CurrentString);
                            display.Text = cumulativeResult.ToString();
                        }
                        else
                            MessageBox.Show("0으로 나눌 수 없습니다.");
                        break;
                }
            }
            operation = "*";
            initial = true;
            isDot = false;
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            if (calcurationCount++ == 1)
                cumulativeResult = double.Parse(CurrentString);
            else
            {
                switch (operation)
                {
                    case "+":
                        cumulativeResult += double.Parse(CurrentString);
                        display.Text = cumulativeResult.ToString();
                        break;
                    case "-":
                        cumulativeResult -= double.Parse(CurrentString);
                        display.Text = cumulativeResult.ToString();
                        break;
                    case "*":
                        cumulativeResult *= double.Parse(CurrentString);
                        display.Text = cumulativeResult.ToString();
                        break;
                    case "/":
                        if (double.Parse(CurrentString) != 0)
                        {
                            cumulativeResult /= double.Parse(CurrentString);
                            display.Text = cumulativeResult.ToString();
                        }
                        else
                            MessageBox.Show("0으로 나눌 수 없습니다.");
                        break;
                }
            }
            operation = "/";
            initial = true;
            isDot = false;
        }

        private void ButtonAC_Click(object sender, EventArgs e)
        {
            CurrentString = "0";
            cumulativeResult = 0;
            initial = true;
            isDot = false;
            calcurationCount = 1;
            operation = "";
            display.Text = CurrentString;
        }

        private void ButtonZero_Click(object sender, EventArgs e)
        {
            if (initial || display.Text == "0")
            {
                CurrentString = "0";
                display.Text = CurrentString;
            }
            else
            {
                CurrentString += "0";
                display.Text = CurrentString;
            }


        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            if (initial)
            {
                CurrentString = "1";
                display.Text = CurrentString;
                initial = false;
            }
            else
            {
                CurrentString += "1";
                display.Text = CurrentString;
            }
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            if (initial)
            {
                CurrentString = "2";
                display.Text = CurrentString;
                initial = false;
            }
            else
            {
                CurrentString += "2";
                display.Text = CurrentString;
            }
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            if (initial)
            {
                CurrentString = "3";
                display.Text = CurrentString;
                initial = false;
            }
            else
            {
                CurrentString += "3";
                display.Text = CurrentString;
            }
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            if (initial)
            {
                CurrentString = "4";
                display.Text = CurrentString;
                initial = false;
            }
            else
            {
                CurrentString += "4";
                display.Text = CurrentString;
            }
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            if (initial)
            {
                CurrentString = "5";
                display.Text = CurrentString;
                initial = false;
            }
            else
            {
                CurrentString += "5";
                display.Text = CurrentString;
            }
        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            if (initial)
            {
                CurrentString = "6";
                display.Text = CurrentString;
                initial = false;
            }
            else
            {
                CurrentString += "6";
                display.Text = CurrentString;
            }
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            if (initial)
            {
                CurrentString = "7";
                display.Text = CurrentString;
                initial = false;
            }
            else
            {
                CurrentString += "7";
                display.Text = CurrentString;
            }
        }

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            if (initial)
            {
                CurrentString = "8";
                display.Text = CurrentString;
                initial = false;
            }
            else
            {
                CurrentString += "8";
                display.Text = CurrentString;
            }
        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            if (initial)
            {
                CurrentString = "9";
                display.Text = CurrentString;
                initial = false;
            }
            else
            {
                CurrentString += "9";
                display.Text = CurrentString;
            }
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            if (!isDot)
            {
                CurrentString += ".";
                display.Text = CurrentString;
                isDot = true;
            }

        }
    }
}

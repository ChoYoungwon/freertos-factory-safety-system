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
    public partial class Form9 : Form
    {
        private int windowNo = 0;
        public Form9()
        {
            InitializeComponent();
        }

        private void mnuNewWindow_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10();
            windowNo++;
            form.Text = "MDI 자식 - " + windowNo;
            form.MdiParent = this;
            form.Show();
        }
    }
}

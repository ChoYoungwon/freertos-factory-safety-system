using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinForms_with_C_
{
    public partial class Form2 : Form
    {
        private MySqlConnection conn = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                DBconn db = new DBconn();
                db.MadangDbConn();
                conn = db.SetConnection();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");
            }

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            search_order();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void btn_modify_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void search_order()
        {
            try
            {
                string query = "SELECT orders.orderid, customer.name, book.bookname, orders.saleprice, orders.orderdate " +
                               "from orders, book, customer " +
                               "where orders.custid = customer.custid and orders.bookid = book.bookid";
                MySqlDataReader reader = null;
                MySqlCommand cmd = new MySqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                listView1.Items.Clear();

                while (reader.Read())
                {
                    Debug.WriteLine($"ID : {reader["orderid"]}, Name :{reader["name"]}, bookname : {reader["bookname"]}, orderdate : {reader["orderdate"]}");
                    ListViewItem item = new ListViewItem();
                    item.Text = reader["orderid"].ToString();
                    item.SubItems.Add(reader["name"].ToString());
                    item.SubItems.Add(reader["bookname"].ToString());
                    item.SubItems.Add(reader["saleprice"].ToString());
                    item.SubItems.Add(reader["orderdate"].ToString());
                    listView1.Items.Add(item);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}

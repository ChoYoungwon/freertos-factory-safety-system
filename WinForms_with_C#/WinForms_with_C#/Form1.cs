using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace WinForms_with_C_
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            searchCustomer();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string id = tbx_ID.Text;
            string name = tbx_name.Text;
            string address = tbx_address.Text;
            string phone = tbx_phone.Text;

            try
            {
                string query = $"insert into customer values({id}, '{name}', '{address}', '{phone}')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("Failed to insert data.");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");
            }
            searchCustomer();
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            string id = tbx_ID.Text;
            string name = tbx_name.Text;
            string address = tbx_address.Text;
            string phone = tbx_phone.Text;

            try
            {
                string query = $"update customer set name = '{name}', address = '{address}', phone = '{phone}' where custid = {id};";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("Failed to modify data.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            searchCustomer();
        }

        private void searchCustomer()
        {
            try
            {
                string query = "select * from customer";
                MySqlDataReader reader = null;
                MySqlCommand cmd = new MySqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                listView1.Items.Clear();
                while (reader.Read())
                {
                    Debug.WriteLine($"ID: {reader["custid"]}, Name: {reader["name"]}, Address: {reader["address"]}, phone: {reader["phone"]}");
                    ListViewItem item = new ListViewItem();
                    item.Text = reader["custid"].ToString();
                    item.SubItems.Add(reader["name"].ToString());
                    item.SubItems.Add(reader["address"].ToString());
                    item.SubItems.Add(reader["phone"].ToString());
                    listView1.Items.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string id = tbx_ID.Text;
            string name = tbx_name.Text;
            string address = tbx_address.Text;
            string phone = tbx_phone.Text;

            try
            {
                string query = $"delete from customer where custid = {id} and name = '{name}' and address = '{address}' and phone = '{phone}';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("Failed to delete data.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            searchCustomer();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                tbx_ID.Text = listView1.SelectedItems[0].Text;
                tbx_name.Text = selectedItem.SubItems[1].Text;
                tbx_address.Text = selectedItem.SubItems[2].Text;
                tbx_phone.Text = selectedItem.SubItems[3].Text;
            }
        }
    }
}

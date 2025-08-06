using MySql.Data.MySqlClient;

namespace WinForms_with_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = null;
            string ip = "127.0.0.1";
            int port = 3306;
            string uid = "root";
            string pwd = "wh852852";
            string dbname = "madangdb";

            string connectionString = $"Server={ip};Port={port};Database={dbname};Uid={uid};Pwd={pwd};CharSet=utf8;";


            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                conn.Ping();
        }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("¼º°ø");
                    conn.Close();
                }
            }
        }
    }
}

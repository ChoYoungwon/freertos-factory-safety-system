using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace WinForms_with_C_
{
    public partial class Form3 : Form
    {
        MySqlConnection connection = null;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                DBconn db = new DBconn();
                db.MadangDbConn();
                connection = db.SetConnection();
                string query = @"
                    create table if not exists user(
                        id varchar(32) primary key,
                        password varchar(88) not null,
                        salt varchar(24) not null,
                        name varchar(32) not null,
                        birth date,
                        phone varchar(20)
                    );";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // 반환값을 체크하지 않고 실행
                cmd.ExecuteNonQuery();

                //MessageBox.Show("User table is ready.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"초기화 오류 : {ex}");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = tbx_ID.Text;
            string password = tbx_password.Text;
            string name = tbx_name.Text;
            string birth = dateTimePicker1.Text;
            string phone = tbx_phone.Text;

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("아이디, 비밀번호, 이름은 필수 항목입니다.");
                return;
            }

            try
            {
                var (hashedPassword, salt) = HashPassword(password);

                string query = @"
                    insert into user (id, password, name, birth, phone, salt)
                    values (@id, @pw, @name, @birth, @phone, @salt);          
                ";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@pw", hashedPassword);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@birth", birth);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@salt", salt);

                if (cmd.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show($"{name}님 계정 등록 실패");
                }
                else
                {
                    MessageBox.Show("등록 성공");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex}");
            }
        }

        public (string hash, string salt) HashPassword(string password)
        {
            // 솔트 생성 (16바이트 크기의 암호학적으로 안전한 난수)
            byte[] saltBytes = RandomNumberGenerator.GetBytes(16);

            // PBKDF2를 사용하여 비밀번호 해시 (SHA-256 알고리즘 사용, 10만번 반복)
            // Key-Stretching으로 무차별 대입 공격 방비
            var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 100000, HashAlgorithmName.SHA256);
            byte[] hashBytes = pbkdf2.GetBytes(32);

            // 솔트와 해시를 Base64 문자열로 변환하여 반환
            return (Convert.ToBase64String(hashBytes), Convert.ToBase64String(saltBytes));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbx_ID.Text = string.Empty;
            tbx_password.Text = string.Empty;
            tbx_name.Text = string.Empty;
            dateTimePicker1.Text = DateTime.Now.ToString("yyyy-MM-dd");
            tbx_phone.Text = string.Empty;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}

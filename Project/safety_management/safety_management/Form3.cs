using MySql.Data.MySqlClient;
using safety_management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace safety_management
{
    public partial class Form3 : Form
    {
        private MySqlConnection conn = null;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 자동으로 객체 리소스 정리(dispose)
            using (Form2 form = new Form2())
            {
                // 폼을 열면 원래 있던 부모 폼을 선택하거나 조작할 수 없음
                form.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string id = tbx_ID.Text;
                string password = tbx_password.Text;

                if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("아이디와 비밀번호는 필수 항목입니다.");
                    return;
                }

                string storedHash = null;
                string storedSalt = null;

                string query = "SELECT password, salt FROM user WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        storedHash = reader["password"].ToString();
                        storedSalt = reader["salt"].ToString();
                    }
                }

                if (storedHash != null && storedSalt != null)
                {
                    if (VerifyPassword(password, storedHash, storedSalt))
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("로그인 실패");
                    }
                }
                else
                {
                    MessageBox.Show("아이디가 존재하지 않습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
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

        private bool VerifyPassword(string password, string storedHash, string storedSalt)
        {
            // db에 저장된 솔트(Base64)를 바이트 배열로 변환
            byte[] saltBytes = Convert.FromBase64String(storedSalt);

            // db에 저장된 해시(Base64)를 바이트 배열로 변환
            byte[] storedHashBytes = Convert.FromBase64String(storedHash);

            // 동일한 방식으로 해시 생성
            var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 100000, HashAlgorithmName.SHA256);
            byte[] newHashBytes = pbkdf2.GetBytes(32);

            // 두 해시 바이트 배열을 비교
            return CryptographicOperations.FixedTimeEquals(storedHashBytes, newHashBytes);
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
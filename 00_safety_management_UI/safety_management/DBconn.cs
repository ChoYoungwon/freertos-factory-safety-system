using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace safety_management
{ 
    internal class DBconn
    {
        public string Ip { get; set; }
        public int Port { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }

        public MySqlConnection connection { get; set; }

        public DBconn(string ip, int port, string database, string userid, string password)
        {
            Ip = ip;
            Port = port;
            Database = database;
            UserId = userid;
            Password = password;
        }

        public DBconn()
        {

        }

        public void MadangDbConn()
        {
            Ip = "localhost";
            Port = 3306;
            Database = "madangdb";
            UserId = "madang";
            Password = "madang";
        }

        public MySqlConnection SetConnection()
        {
            string connectionString = $"Server={Ip};Port={Port};Database={Database};Uid={UserId};Pwd={Password};CharSet=utf8;";
            connection = new MySqlConnection(connectionString);
            connection.Open();
            connection.Ping();
            return connection;
        }

        public override string ToString()
        {
            return $"Server={Ip};Port={Port};Database={Database};Uid={UserId};Pwd={Password};CharSet=utf8;";
        }
    }
}

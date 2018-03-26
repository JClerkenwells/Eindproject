using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace LaRustique
{
    class Database
    {
        private const string SERVER = "sql11.freesqldatabase.com";
        private const string DATABASE = "sql11227545";
        private const string UID = "sql11227545";
        private const string PASSWORD = "Se57gU8Es2";

        /// <summary>
        /// MySqlCommand(sql, con); mySqlDataReader = cmd.ExecuteReader();
        /// </summary>
        /// <returns>Mysql connection</returns>
        public static MySqlConnection conBuilder()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;

            MySqlConnection con = new MySqlConnection(builder.ToString());

            builder = null;
            return con;
        }

        public static byte[] CreateSalt(int size)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);

            return buff;
        }

        public byte[] GenerateHash(string input, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
            SHA256Managed shaHash = new SHA256Managed();
            byte[] hash = shaHash.ComputeHash(bytes);

            return hash;
        }
    }
}

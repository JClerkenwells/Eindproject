using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
    }
}

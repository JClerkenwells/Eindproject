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

namespace LaRustique
{
    public partial class Werknemers : Form
    {
        public Werknemers()
        {
            InitializeComponent();
            laadWerknemersLb(aLbWerknemers);
            aLbWerknemers.Refresh();
        }

        private void logUitMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Wilt u uitloggen ?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Login x = new Login();
                this.Hide();
                x.ShowDialog();
                this.Close();
            }
        }
        /// <summary>
        /// Haalt werknemers uit db
        /// </summary>
        /// <returns>Listbox ID - naam  - email - admin</returns>
        private static ListBox laadWerknemersLb(ListBox lBox)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            builder.Server = Database.SERVER;
            builder.Database = Database.DATABASE;
            builder.UserID = Database.UID;
            builder.Password = Database.PASSWORD;

            MySqlConnection con = new MySqlConnection(builder.ToString());

            builder = null;

            string sql = "SELECT ID, naam, email, admin FROM gebruikers";

            con.Open();

            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader myReader = cmd.ExecuteReader();

            while(myReader.Read())
            {
                lBox.Items.Add(myReader[1]);
            }
            myReader.Dispose();
            con.Close();
            con.Dispose();

            return lBox;
        }
    }
}

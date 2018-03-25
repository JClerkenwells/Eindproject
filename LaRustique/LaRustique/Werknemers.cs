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
        private string _ID, _naam, _email, _admin;
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
            using (MySqlConnection con = Database.conBuilder())
            {
                string sql = "SELECT ID, naam, email, admin FROM gebruikers";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                using (MySqlDataReader myReader = cmd.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        lBox.Items.Add(myReader[1]);
                    }
                }
                return lBox;
            }
        }

        private void btnLaadGegevens_Click(object sender, EventArgs e)
        {
            aGbGegevens.Visible = true;
            string naam = aLbWerknemers.SelectedItem.ToString();

            using (MySqlConnection con = Database.conBuilder())
            {
                string sql = string.Format("SELECT ID, naam, email, admin FROM gebruikers WHERE naam = '{0}'", naam);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);

                using (MySqlDataReader myReader = cmd.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        txtID.Text = myReader["ID"].ToString();
                        txtNaam.Text = myReader["naam"].ToString();
                        txtEmail.Text = myReader["email"].ToString();

                        //Als admin ipv 0 / 1 waardes Ja / Nee
                        if (myReader["admin"].Equals(true)) { txtAdmin.Text = "Ja"; }
                        else { txtAdmin.Text = "Nee"; }

                        //Waardes om door te geven
                        _ID = myReader["ID"].ToString();
                        _naam = myReader["naam"].ToString();
                        _email = myReader["email"].ToString();
                        _admin = myReader["admin"].ToString();
                    }
                }
            }
        }

        private void btnWijzig_Click(object sender, EventArgs e)
        {
            WerknemerWijzig x = new WerknemerWijzig(_ID, _naam, _email, Convert.ToBoolean(_admin));
            x.ShowDialog();

            if (x.DialogResult == DialogResult.OK)
            {
                this.Refresh();
            }
        }
    }
}

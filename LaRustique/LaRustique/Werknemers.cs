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
        private string _ID, _naam, _email, _tel, _admin;
        public Werknemers(bool admin)
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

        private void btnWerknmrToevoegen_Click(object sender, EventArgs e)
        {
            WerknemerToevoegen x = new WerknemerToevoegen();
            x.ShowDialog();
            laadWerknemersLb(aLbWerknemers);
        }
        /// <summary>
        /// Haalt werknemers uit db
        /// </summary>
        /// <returns>Listbox ID - naam  - email - admin</returns>
        private static ListBox laadWerknemersLb(ListBox lb)
        {
            using (MySqlConnection con = Database.conBuilder())
            {
                string sql = "SELECT naam FROM gebruikers";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                using (MySqlDataReader myReader = cmd.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        lb.Items.Add(myReader[0]);
                    }
                }
            }
            return lb;
        }
        private void btnLaadGegevens_Click(object sender, EventArgs e)
        {
            string naam;
            //Buttons worden pas zichtbaar als een werknemer is geselecteerd
            aGbGegevens.Visible = true;
            btnWijzig.Visible = true;
            btnVerwijder.Visible = true;
            
            //Fix voor crash als naam geen waarde heeft
            try
            {
                naam = aLbWerknemers.SelectedItem.ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            using (MySqlConnection con = Database.conBuilder())
            {
                try
                {
                    con.Open();
                }
                catch(Exception ex)
                {
                    Database.ConErrorMessage(ex);
                    return;
                }

                string sql = "SELECT ID, naam, email, tel, admin FROM gebruikers WHERE naam = @naam";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@naam", naam);

                using (MySqlDataReader myReader = cmd.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        txtID.Text = myReader["ID"].ToString();
                        txtNaam.Text = myReader["naam"].ToString();
                        txtEmail.Text = myReader["email"].ToString();
                        txtTel.Text = myReader["tel"].ToString();

                        //Als admin ipv 0 / 1 waardes Ja / Nee
                        if (myReader["admin"].Equals(true)) { txtAdmin.Text = "Ja"; }
                        else { txtAdmin.Text = "Nee"; }

                        //Waardes om door te geven
                        _ID = myReader["ID"].ToString();
                        _naam = myReader["naam"].ToString();
                        _email = myReader["email"].ToString();
                        _admin = myReader["admin"].ToString();
                        _tel = myReader["tel"].ToString();
                    }
                }
            }
        }

        private void btnWijzig_Click(object sender, EventArgs e)
        {
            WerknemerWijzig x = new WerknemerWijzig(_ID, _naam, _tel, _email, Convert.ToBoolean(_admin));
            x.ShowDialog();

            if (x.DialogResult == DialogResult.OK)
            {
                aLbWerknemers.Items.Clear();
                laadWerknemersLb(aLbWerknemers);
                aLbWerknemers.Refresh();
            }
        }
    }
}

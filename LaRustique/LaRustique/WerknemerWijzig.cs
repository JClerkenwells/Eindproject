using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaRustique
{
    public partial class WerknemerWijzig : Form
    {
        private string _ID, _naam, _email;

        private bool _admin;

        public WerknemerWijzig(string ID, string naam, string email, bool admin)
        {
            InitializeComponent();

            //Zet waardes in textbox
            txtID.Text = ID;
            txtNaam.Text = naam;
            txtEmail.Text = email;
            if (admin) { aRbAdminJa.Checked = true; }
            else { aRbAdminNee.Checked = true; }

            _ID = ID;
            _naam = naam;
            _email = email;
            _admin = admin;
        }

        private void btnWijzig_Click(object sender, EventArgs e)
        {
            string naam, email;
            bool admin;

            //Zet nieuwe waardes in variables
            naam = txtNaam.Text;
            email = txtEmail.Text;
            if (aRbAdminJa.Checked) { admin = true; }
            else { admin = false; }

            using (MySql.Data.MySqlClient.MySqlConnection con = Database.conBuilder())
            {
                string sql = string.Format("UPDATE 'gebruikers' SET 'naam' = '{0}', 'email' = '{1}', 'admin' = '{2}' WHERE 'gebruikers'.'ID' = {3}", naam, email, admin, _ID);
                con.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    //Als update is uitgevoerd, msgbox om success te melden en scherm te sluiten
                    DialogResult result = MessageBox.Show("Wijziging succesvol !", "Gegevens succesvol gewijzigd", MessageBoxButtons.OK);
                    if(result == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Er is iets fout gegaan");
                    Console.WriteLine(ex.Data);
                }
            }
        }

        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

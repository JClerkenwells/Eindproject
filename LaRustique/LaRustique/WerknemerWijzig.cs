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

        public WerknemerWijzig(string ID, string naam, string tel, string email, bool admin)
        {
            InitializeComponent();

            //Zet waardes in textbox
            txtID.Text = ID;
            txtNaam.Text = naam;
            txtTel.Text = tel;
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
            string naam, email, tel;
            int admin;

            #region Check Gegevens
            //Check of email geldig is
            if (!Database.checkEmailValid(txtEmail.Text))
            {
                MessageBox.Show("Ongeldige E-mail");
                return;
            }
            //Check of naam leeg is
            if (txtNaam.Text == "")
            {
                MessageBox.Show("Vul een naam in");
                return;
            }
            //Check of naam geldig is
            if (txtNaam.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Naam kan geen nummers bevatten");
                return;
            }
            //Check of tel een nummer is
            try
            {
                //String >> int32 >> string
                tel = Convert.ToInt32(txtTel.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Voer een geldig telefoonnummer in");
                Console.WriteLine(ex.Message);
                return;
            }
            #endregion
            //Zet nieuwe waardes in variables
            naam = txtNaam.Text;
            email = txtEmail.Text;
            tel = txtTel.Text;

            if (aRbAdminJa.Checked) { admin = 1; }
            else { admin = 0; }

            using (MySql.Data.MySqlClient.MySqlConnection con = Database.conBuilder())
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

                string sql = "UPDATE gebruikers SET naam = @naam, email = @email, tel = @tel, admin = @admin WHERE gebruikers.ID = @ID";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, con);
                //Parameters
                cmd.Parameters.AddWithValue("@naam", naam);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@tel", tel);
                cmd.Parameters.AddWithValue("@admin", admin);
                cmd.Parameters.AddWithValue("@ID", _ID);
                //Voer de query uit
                cmd.ExecuteNonQuery();
                //Als update is uitgevoerd, msgbox om success te melden en scherm te sluiten
                DialogResult result = MessageBox.Show("Wijziging succesvol !", "Gegevens succesvol gewijzigd", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

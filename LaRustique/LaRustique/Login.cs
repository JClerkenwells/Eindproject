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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            #region Placeholders
            //Zet de placeholders van gebruikersnaam en wachtwoord
            txtUsername.Font = new Font(txtUsername.Font, FontStyle.Italic);
            txtUsername.ForeColor = Color.Gray;
            txtUsername.Text = "E-Mail";

            //Wachtwoord
            txtPassword.Font = new Font(txtPassword.Font, FontStyle.Italic);
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Text = "Wachtwoord";
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            //Verwijder placeholder als txtbox geselecteerd is
            if (txtUsername.Text == "E-Mail")
            {
                txtUsername.Clear();
                txtUsername.ForeColor = Color.Black;
                txtUsername.Font = new Font(txtUsername.Font, FontStyle.Regular);
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            //Als de tekst leeg is word de placeholder teruggezet
            if (txtUsername.Text == "")
            {
                txtUsername.Font = new Font(txtUsername.Font, FontStyle.Italic);
                txtUsername.ForeColor = Color.Gray;
                txtUsername.Text = "E-Mail";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            //Verwijder placeholder als txtbox geselecteerd is
            if (txtPassword.Text == "Wachtwoord")
            {
                txtPassword.Clear();
                txtPassword.Font = new Font(txtPassword.Font, FontStyle.Regular);
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            //Als de tekst leeg is word de placeholder teruggezet
            if (txtPassword.Text == "")
            {
                txtPassword.Font = new Font(txtPassword.Font, FontStyle.Italic);
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Wachtwoord";
            }
        }
        #endregion

        private void aButton_Click(object sender, EventArgs e)
        {
            #region Database inloggen
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Alles staat in using voor garbage collection
            
            
            using (MySqlConnection con = Database.conBuilder())
            {
                try
                {
                    con.Open();
                }
                catch
                {
                    MessageBox.Show("Er is iets misgegaan met de verbinding");
                }

                string sql = "SELECT * FROM gebruikers WHERE email = @mail";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@mail", txtUsername.Text);

                using (MySqlDataReader myReader = cmd.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        ////Als wachtwoord fout is
                        //if (myReader[3].ToString().ToLower() == txtUsername.Text.ToLower() && txtPassword.Text != myReader[2].ToString())
                        //{
                        //    MessageBox.Show("Wachtwoord incorrect");
                        //}
                        //
                        ////Als email fout is
                        //else if (myReader[3].ToString().ToLower() != txtUsername.Text.ToLower() && txtPassword.Text == myReader[2].ToString())
                        //{
                        //    MessageBox.Show("E-Mail incorrect");
                        //}

                        if (myReader["email"].ToString().ToLower() == txtUsername.Text.ToLower() && myReader["password"].ToString() == txtPassword.Text)
                        {
                            Startpagina x = new Startpagina(myReader["naam"].ToString(), myReader["email"].ToString(), Convert.ToBoolean(myReader["admin"]));
                            this.Hide();
                            x.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Gegevens Incorrect");
                        }
                    }
                }
            }
                    
            #endregion
        }
    }
}

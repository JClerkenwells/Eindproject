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

            String SERVER = "sql11.freesqldatabase.com";
            String DATABASE = "sql11227545";
            String UID = "sql11227545";
            String PASSWORD = "Se57gU8Es2";

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;

            string connectionbuilder = builder.ToString();

            builder = null;

            MySqlConnection con = new MySqlConnection(connectionbuilder);

            string sql = "SELECT * FROM gebruikers";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader myReader = cmd.ExecuteReader();

            while (myReader.Read())
            {
                if (myReader[3].ToString().ToLower() == txtUsername.Text.ToLower() && myReader[2].ToString() == txtPassword.Text)
                {
                    Startpagina x = new Startpagina(myReader[1].ToString(), myReader[3].ToString(), Convert.ToBoolean(myReader[4]));
                    this.Hide();
                    x.ShowDialog();
                    this.Close();
                }
                //Als wachtwoord fout is
                else if (myReader[3].ToString().ToLower() == txtUsername.Text.ToLower() && txtPassword.Text != myReader[2].ToString())
                {
                    MessageBox.Show("Wachtwoord incorrect");
                }
                //Als email fout is
                else if (myReader[3].ToString().ToLower() != txtUsername.Text.ToLower() && txtPassword.Text == myReader[2].ToString())
                {
                    MessageBox.Show("E-Mail incorrect");
                }
            }
            //con.Close();
            #endregion
        }
    }
}

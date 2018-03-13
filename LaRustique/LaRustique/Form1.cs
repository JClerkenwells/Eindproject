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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Zet de placeholders van gebruikersnaam en wachtwoord
            txtUsername.Font = new Font(txtUsername.Font, FontStyle.Italic);
            txtUsername.ForeColor = Color.Gray;
            txtUsername.Text = "Gebruikersnaam";

            //Wachtwoord
            txtPassword.Font = new Font(txtPassword.Font, FontStyle.Italic);
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Text = "Wachtwoord";
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            //Verwijder placeholder als txtbox geselecteerd is
            if (txtUsername.Text == "Gebruikersnaam")
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
                txtUsername.Text = "Gebruikersnaam";
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
    }
}

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
    public partial class Startpagina : Form
    {
        public Startpagina(string naam, string email, bool admin)
        {
            InitializeComponent();

            aLabelNaam.Text = naam;
            aLabelEmail.Text = email;

            if (admin)
            {
                
            }
        }

        private void logUitToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void Klant_Click(object sender, EventArgs e)
        {
            Klanten x = new Klanten();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }
    }
}

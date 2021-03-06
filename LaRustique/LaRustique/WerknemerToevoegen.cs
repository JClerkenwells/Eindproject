﻿using System;
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
    public partial class WerknemerToevoegen : Form
    {
        public WerknemerToevoegen()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            int nmr, admin;

            #region Check Gegevens
            //Check of naam leeg is
            if (txtNaam.Text == "")
            {
                MessageBox.Show("Voer een naam in");
                return;
            }
            
            //Check of tel een nummer is
            try
            {
                nmr = Convert.ToInt32(txtTel.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Voer een geldig telefoonnummer in");
                Console.WriteLine(ex.Message);
                return;
            }

            //Check of wachtwoord gelijk is
            if (txtWachtwoord.Text != txtWachtwoordCheck.Text)
            {
                MessageBox.Show("Wachtwoord niet gelijk");
                return;
            }
            
            //Check of email valid is
            if (!Database.checkEmailValid(txtEmail.Text))
            {
                MessageBox.Show("Voer een geldige email in");
                return;
            }
            #endregion
            //Check of admin is
            if (aRbAdminJa.Checked) { admin = 1; }
            else { admin = 0; }

            //Maak connectie, parameters en insert
            using (MySqlConnection con = Database.conBuilder())
            {
                string sql = "INSERT INTO gebruikers (naam, password, tel, email, admin) VALUES (@naam, @pass, @tel, @email, @admin)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@naam", txtNaam.Text);
                cmd.Parameters.AddWithValue("@pass", Database.GenerateHash(txtWachtwoord.Text));
                cmd.Parameters.AddWithValue("@tel", nmr);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@admin", admin);

                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    Database.ConErrorMessage(ex);
                    return;
                }
                //Voer de query uit als de verbinding werkt
                cmd.ExecuteNonQuery();

                //Als query is uitgevoerd, msgbox om success te melden en scherm te sluiten
                DialogResult result = MessageBox.Show("Succesvol toegevoegd !");
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }

        }
    }
}

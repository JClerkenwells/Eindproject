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
    public partial class Klanten : Form
    {
        private string _naam, _adres, _postcode, _plaats, _email, _tel;
        private bool _admin;
        public Klanten(bool admin)
        {
            InitializeComponent();
            //Listbox vult en refreshed om waardes te laten zien
            LaadKlanten(aLbKlanten);
            aLbKlanten.Refresh();

            //Item alleen zichtbaar als admin
            if (admin)
            {
                werknemersMenuItem.Visible = true;
            }
            //Waardes om door te geven
            _admin = admin;
        }
        //Laad klanten in de listbox
        private static ListBox LaadKlanten(ListBox lb)
        {
            using (MySqlConnection con = Database.conBuilder())
            {
                try
                {
                    con.Open();
                }
                catch(Exception ex)
                {
                    Database.ConErrorMessage(ex);

                    //Returned zonder waardes als connectie niet lukt
                    return lb;
                }

                string sql = "SELECT naam FROM klanten";
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
        //Laad de gegevens van een klant uit de lb
        private void btnLaadKlant_Click(object sender, EventArgs e)
        {
            string naam;
            //Buttons worden pas zichtbaar als een werknemer is geselecteerd
            aGbGegevens.Visible = true;
            btnWijzig.Visible = true;
            btnVerwijder.Visible = true;

            //Fix voor crash als naam geen waarde heeft
            try
            {
                naam = aLbKlanten.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            //Haal gegevens uit de DB
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
                string sql = "SELECT naam, adres, postcode, plaats, email, tel FROM klanten WHERE naam = @naam";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@naam", naam);

                using (MySqlDataReader myReader = cmd.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        //Zet waardes in txt velden
                        txtNaam.Text = myReader["naam"].ToString();
                        txtAdres.Text = myReader["adres"].ToString();
                        txtPostcode.Text = myReader["postcode"].ToString();
                        txtPlaats.Text = myReader["plaats"].ToString();
                        txtEmail.Text = myReader["email"].ToString();
                        txtTel.Text = myReader["tel"].ToString();

                        //Zet waardes in var om mee te geven
                        _naam = myReader["naam"].ToString();
                        _adres = myReader["adres"].ToString();
                        _postcode = myReader["postcode"].ToString();
                        _plaats = myReader["plaats"].ToString();
                        _email = myReader["email"].ToString();
                        _tel = myReader["tel"].ToString();
                    }
                }
            }
        }
    }
}

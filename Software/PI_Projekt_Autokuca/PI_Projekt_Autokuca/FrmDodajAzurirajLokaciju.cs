using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdreseLib;
using PI_Projekt_Autokuca.Klase;

namespace PI_Projekt_Autokuca
{
    public partial class FrmDodajAzurirajLokaciju : Form
    {
        public bool Azuriraj { get; set; }
        public Adrese Odabrana { get; set; }
        public FrmDodajAzurirajLokaciju(bool azuriraj = false, Adrese odabrana = null)
        {
            InitializeComponent();
            Azuriraj = azuriraj;
            Odabrana = odabrana;
        }

        private void FrmDodajAzurirajLokaciju_Load(object sender, EventArgs e)
        {
            txtVrsta.Text = "Servis";
            txtVrsta.Enabled = false;
            if (Azuriraj && Odabrana != null)
            {
                txtBroj.Text = Odabrana.Broj;
                txtMjesto.Text = Odabrana.Mjesto;
                txtNaziv.Text = Odabrana.NazivPodruznice;
                txtPostBroj.Text = Odabrana.PostanskiBroj;
                txtRadVrijemeDo.Text = Odabrana.RadnoVrijemeDo.Value.Hours.ToString();
                txtRadVrijemeOd.Text = Odabrana.RadnoVrijemeOd.Value.Hours.ToString();
                txtUlica.Text = Odabrana.Ulica;
                txtVrsta.Text = Odabrana.OpisPodruznice;
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (!Azuriraj)
            {
                Adrese nova = new Adrese()
                {
                    Broj = txtBroj.Text,
                    Mjesto = txtMjesto.Text,
                    NazivPodruznice = txtNaziv.Text,
                    OpisPodruznice = txtVrsta.Text,
                    PostanskiBroj = txtPostBroj.Text,
                    RadnoVrijemeDo = new TimeSpan(int.Parse(txtRadVrijemeDo.Text), 0, 0),
                    RadnoVrijemeOd = new TimeSpan(int.Parse(txtRadVrijemeOd.Text), 0, 0),
                    Ulica = txtUlica.Text
                };
                RepozitorijAutokuca.KreirajLokaciju(nova);
                Close();
            }
            else
            {
                string broj = txtBroj.Text;
                string mjesto = txtMjesto.Text;
                string nazivPodruznice = txtNaziv.Text;
                string opisPodruznice = txtVrsta.Text;
                string postanskiBroj = txtPostBroj.Text;
                TimeSpan radnoVrijemeDo = new TimeSpan(int.Parse(txtRadVrijemeDo.Text), 0, 0);
                TimeSpan radnoVrijemeOd = new TimeSpan(int.Parse(txtRadVrijemeOd.Text), 0, 0);
                string ulica = txtUlica.Text;
                RepozitorijAutokuca.AzurirajLokaciju(Odabrana.IDAdrese, broj, mjesto, nazivPodruznice, opisPodruznice, postanskiBroj, radnoVrijemeOd, radnoVrijemeDo, ulica);
                Close();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

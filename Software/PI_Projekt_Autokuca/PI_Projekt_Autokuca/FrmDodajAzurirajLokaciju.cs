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
            this.KeyPreview = true;
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
            if (!ProvjeraUnosa.ProvjeriPopunjenostPoljaAdrese(txtBroj.Text, txtUlica.Text, txtMjesto.Text, txtPostBroj.Text, txtNaziv.Text, txtVrsta.Text, txtRadVrijemeOd.Text, txtRadVrijemeDo.Text))
            {
                MessageBox.Show("Nisu popunjena sva polja!");
            }
            else
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
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDodajAzurirajLokaciju_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                string path = System.IO.Directory.GetCurrentDirectory();
                string putanja = path.Remove(path.Length - 10);
                Help.ShowHelp(this, "file://" + putanja + "\\Autokuca-Help.chm", HelpNavigator.Topic, "Dodaj ili azuriraj lokaciju.htm");
            }
        }
    }
}

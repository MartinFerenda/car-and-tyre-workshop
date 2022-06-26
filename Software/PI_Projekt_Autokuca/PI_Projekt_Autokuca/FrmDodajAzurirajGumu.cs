using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_Projekt_Autokuca.Klase;
using SkladisteLib;

namespace PI_Projekt_Autokuca
{
    public partial class FrmDodajAzurirajGumu : Form
    {
        public Gume GumaZaAzuriranje { get; set; }
        public FrmDodajAzurirajGumu(Gume zaAzurirati = null)
        {
            InitializeComponent();
            GumaZaAzuriranje = zaAzurirati;
        }

        private void FrmDodajAzurirajGumu_Load(object sender, EventArgs e)
        {
            if (GumaZaAzuriranje == null)
            {
                cmbKorisnik.DataSource = RepozitorijAutokuca.DohvatiVlasnike();
                cmbKorisnik.SelectedItem = null;
                cmbProizvodac.DataSource = RepozitorijAutokuca.DohvatiProizvodace();
            }
            else
            {
                txtKolicina.Text = GumaZaAzuriranje.KolicinaNaSkladistu.ToString();
                txtNabavna.Text = GumaZaAzuriranje.NabavnaCijena.ToString();
                txtProdajna.Text = GumaZaAzuriranje.ProdajnaCijena.ToString();
                txtPromjer.Text = GumaZaAzuriranje.Promjer.ToString();
                txtSifra.Text = GumaZaAzuriranje.SifraGume.ToString();
                txtSrina.Text = GumaZaAzuriranje.Sirina.ToString();
                txtVisina.Text = GumaZaAzuriranje.Visina.ToString();

                cmbKorisnik.DataSource = RepozitorijAutokuca.DohvatiVlasnike();
                if (GumaZaAzuriranje.Vlasnik != null)
                {
                    cmbKorisnik.Text = GumaZaAzuriranje.Vlasnik.ToString();
                }
                else
                {
                    cmbKorisnik.Text = "";
                }
                
                cmbProizvodac.DataSource = RepozitorijAutokuca.DohvatiProizvodace();
                cmbProizvodac.Text = GumaZaAzuriranje.Proizvodac.ToString();
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string poruka = "";
            if (!ProvjeraUnosa.ProvjeriPopunjenostPoljaGume(txtSifra.Text, txtSrina.Text, txtVisina.Text, txtPromjer.Text, txtKolicina.Text, txtNabavna.Text, txtProdajna.Text))
            {
                poruka += "Nisu popunjena sva polja!\r\n";
            }
            else
            {
                int kolicinaNaSkladistu = int.Parse(txtKolicina.Text);
                decimal nabavnaCijena = decimal.Parse(txtNabavna.Text);
                decimal prodajnaCijena = decimal.Parse(txtProdajna.Text);
                int sirina = int.Parse(txtSrina.Text);
                int visina = int.Parse(txtVisina.Text);
                int promjer = int.Parse(txtPromjer.Text);

                if (!ProvjeraUnosa.IspravnaKolicina(kolicinaNaSkladistu))
                {
                    poruka += "Nije unesena ispravna količina!\r\n";
                }
                if (!ProvjeraUnosa.IspravnaCijena(nabavnaCijena, prodajnaCijena))
                {
                    poruka += "Nije unesena ispravna cijena!\r\n";
                }
                if (!ProvjeraUnosa.IspravneDimenzije(sirina, visina, promjer))
                {
                    poruka += "Dimenzije gume nisu ispravne!";
                }  
            }

            if (poruka == "")
            {
                if (GumaZaAzuriranje == null)
                {
                    Gume nova = new Gume()
                    {
                        KolicinaNaSkladistu = int.Parse(txtKolicina.Text),
                        NabavnaCijena = decimal.Parse(txtNabavna.Text),
                        ProdajnaCijena = decimal.Parse(txtProdajna.Text),
                        Proizvodac = cmbProizvodac.SelectedItem as Proizvodaci,
                        Promjer = int.Parse(txtPromjer.Text),
                        Sirina = int.Parse(txtSrina.Text),
                        Visina = int.Parse(txtVisina.Text),
                        SifraGume = int.Parse(txtSifra.Text),
                        Vlasnik = cmbKorisnik.SelectedItem as Vlasnik
                    };
                    RepozitorijAutokuca.KreirajGumu(nova);
                    Close();
                }
                else
                {
                    GumaZaAzuriranje.KolicinaNaSkladistu = int.Parse(txtKolicina.Text);
                    GumaZaAzuriranje.NabavnaCijena = decimal.Parse(txtNabavna.Text);
                    GumaZaAzuriranje.ProdajnaCijena = decimal.Parse(txtProdajna.Text);
                    GumaZaAzuriranje.Proizvodac = cmbProizvodac.SelectedItem as Proizvodaci;
                    GumaZaAzuriranje.Promjer = int.Parse(txtPromjer.Text);
                    GumaZaAzuriranje.Sirina = int.Parse(txtSrina.Text);
                    GumaZaAzuriranje.Visina = int.Parse(txtVisina.Text);
                    GumaZaAzuriranje.SifraGume = int.Parse(txtSifra.Text);
                    GumaZaAzuriranje.Vlasnik = cmbKorisnik.SelectedItem as Vlasnik;
                    RepozitorijAutokuca.AzurirajGumu(GumaZaAzuriranje);
                    Close();
                }
            }
            else
            {
                MessageBox.Show(poruka);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

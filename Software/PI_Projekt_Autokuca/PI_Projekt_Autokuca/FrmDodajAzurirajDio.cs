using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkladisteLib;
using PI_Projekt_Autokuca.Klase;
using PI_Projekt_Autokuca.Iznimke;

namespace PI_Projekt_Autokuca
{
    public partial class FrmDodajAzurirajDio : Form
    {
        public bool Azuriraj { get; set; }
        public AutomobilskiDijelovi OdabraniDio { get; set; }
        public FrmDodajAzurirajDio(bool azuriraj, AutomobilskiDijelovi odabraniDio)
        {
            InitializeComponent();
            Azuriraj = azuriraj;
            OdabraniDio = odabraniDio;
        }

        private void DodajAzurirajDio_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            List<string> original = new List<string>()
            {
                "Da",
                "Ne"
            };
            cmbOriginal.DataSource = original;
            cmbProizvodac.DataSource = RepozitorijAutokuca.DohvatiProizvodace();
            if (Azuriraj)
            {
                txtKolSkladiste.Text = OdabraniDio.KolicinaNaSkladistu.ToString();
                txtNabCijena.Text = OdabraniDio.NabavnaCijena.ToString();
                txtNaziv.Text = OdabraniDio.Naziv;
                cmbOriginal.Text = ProvjeriOriginal();
                txtProdCijena.Text = OdabraniDio.ProdajnaCijena.ToString();
                txtSifra.Text = OdabraniDio.SifraDijela.ToString();
                txtSifra.Enabled = false;
                cmbProizvodac.Text = OdabraniDio.Proizvodac.ToString();
            }
        }
        private string ProvjeriOriginal()
        {
            if (OdabraniDio.Original == true)
            {
                return "Da";
            }
            else
            {
                return "Ne";
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string poruka = "";
            
            if (!ProvjeraUnosa.PopunjenaSvaPolja(txtKolSkladiste.Text, txtNabCijena.Text, txtProdCijena.Text, txtNaziv.Text, txtSifra.Text))
            {
                poruka += "Nisu popunjena sva polja!\r\n";
            }
            else
            {
                int kolicinaNaSkladistu = int.Parse(txtKolSkladiste.Text);
                decimal nabavnaCijena = decimal.Parse(txtNabCijena.Text);
                decimal prodajnaCijena = decimal.Parse(txtProdCijena.Text);

                if (!ProvjeraUnosa.IspravnaKolicina(kolicinaNaSkladistu))
                {
                    poruka += "Nije unesena ispravna količina!\r\n";
                }
                if (!ProvjeraUnosa.IspravnaCijena(nabavnaCijena, prodajnaCijena))
                {
                    poruka += "Nije unesena ispravna cijena!\r\n";
                }
            }

            if (poruka == "")
            {

                if (!Azuriraj)
                {

                    AutomobilskiDijelovi novi = new AutomobilskiDijelovi()
                    {
                        KolicinaNaSkladistu = int.Parse(txtKolSkladiste.Text),
                        NabavnaCijena = decimal.Parse(txtNabCijena.Text),
                        Naziv = txtNaziv.Text,
                        Original = OriginalOdabir(),
                        ProdajnaCijena = decimal.Parse(txtProdCijena.Text),
                        Proizvodac = cmbProizvodac.SelectedItem as Proizvodaci,
                        SifraDijela = int.Parse(txtSifra.Text)
                    };
                    try
                    {
                        RepozitorijAutokuca.KreirajAutomobilskiDio(novi);
                        Close();
                    }
                    catch (IDAlreadyExists ex)
                    {
                        MessageBox.Show(ex.Obavijest);
                    }
                }
                else
                {
                    OdabraniDio.KolicinaNaSkladistu = int.Parse(txtKolSkladiste.Text);
                    OdabraniDio.NabavnaCijena = decimal.Parse(txtNabCijena.Text);
                    OdabraniDio.Naziv = txtNaziv.Text;
                    OdabraniDio.Original = OriginalOdabir();
                    OdabraniDio.ProdajnaCijena = decimal.Parse(txtProdCijena.Text);
                    OdabraniDio.Proizvodac = cmbProizvodac.SelectedItem as Proizvodaci;
                    OdabraniDio.SifraDijela = int.Parse(txtSifra.Text);
                    RepozitorijAutokuca.AzurirajAutomobilskiDio(OdabraniDio);
                    Close();
                }
            }
            else
            {
                MessageBox.Show(poruka);
            }
        }
        private bool OriginalOdabir()
        {
            if (cmbOriginal.SelectedItem.ToString() == "Da")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDodajAzurirajDio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                string path = System.IO.Directory.GetCurrentDirectory();
                string putanja = path.Remove(path.Length - 10);
                Help.ShowHelp(this, "file://" + putanja + "\\Autokuca-Help.chm", HelpNavigator.Topic, "Dodaj ili azuriraj dio.htm");
            }
        }
    }
}

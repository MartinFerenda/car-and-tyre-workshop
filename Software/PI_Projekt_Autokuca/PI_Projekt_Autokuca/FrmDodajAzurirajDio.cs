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
                cmbOriginal.Text = OdabraniDio.Original.ToString();
                txtProdCijena.Text = OdabraniDio.ProdajnaCijena.ToString();
                txtSifra.Text = OdabraniDio.SifraDijela.ToString();
                cmbProizvodac.Text = OdabraniDio.Proizvodac.ToString();
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
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
    }
}

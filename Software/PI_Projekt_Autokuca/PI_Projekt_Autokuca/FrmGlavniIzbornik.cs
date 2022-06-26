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

namespace PI_Projekt_Autokuca
{
    public partial class FrmGlavniIzbornik : Form
    {
        public FrmGlavniIzbornik()
        {
            InitializeComponent();
        }

        private void FrmGlavniIzbornik_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            RepozitorijAutokuca.PrijavljeniKorisnik = null;
            Osvjezi();
        }

        private void btnPrikazLokacijaServisa_Click(object sender, EventArgs e)
        {
            FrmPrikazLokacijaServisa form = new FrmPrikazLokacijaServisa();
            form.ShowDialog();
        }

        private void btnPrikazAutomobila_Click(object sender, EventArgs e)
        {

        }

        private void btnPregledStanjaVozila_Click(object sender, EventArgs e)
        {

        }

        private void btnPregledRacuna_Click(object sender, EventArgs e)
        {

        }

        private void btnPrijavaKvara_Click(object sender, EventArgs e)
        {

        }

        private void btnRezervacijaTermina_Click(object sender, EventArgs e)
        {
            if (RepozitorijAutokuca.PrijavljeniKorisnik != null && RepozitorijAutokuca.PrijavljeniKorisnik.Uloga != Uloge.NeregistriraniKorisnik)
            {
                FrmIzborRezervacije form = new FrmIzborRezervacije();
                form.ShowDialog();
            }
        }

        private void btnZamjenaGuma_Click(object sender, EventArgs e)
        {

        }

        private void btnAutopraonica_Click(object sender, EventArgs e)
        {

        }

        private void btnSkladisteIEvidencija_Click(object sender, EventArgs e)
        {
            if (RepozitorijAutokuca.PrijavljeniKorisnik.Uloga == Uloge.Administrator || RepozitorijAutokuca.PrijavljeniKorisnik.Uloga == Uloge.Zaposlenik)
            {
                FrmSkladisteIEvidencija form = new FrmSkladisteIEvidencija();
                form.ShowDialog();
            }
            else
            {
                FrmMojeGume form = new FrmMojeGume();
                form.ShowDialog();
            }
        }

        private void btnMojRacun_Click(object sender, EventArgs e)
        {

        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            RepozitorijAutokuca.PrijavljeniKorisnik = null;
            PrijavaPomocna form = new PrijavaPomocna();
            form.ShowDialog();
            Osvjezi();
        }
        private void Osvjezi() 
        {
            if (RepozitorijAutokuca.PrijavljeniKorisnik != null)
            {
                btnOdjava.Text = "Odjava";
                if (RepozitorijAutokuca.PrijavljeniKorisnik.Uloga != Uloge.NeregistriraniKorisnik)
                {
                    gboxSkladiste.Visible = true;
                    if (RepozitorijAutokuca.PrijavljeniKorisnik.Uloga == Uloge.Administrator || RepozitorijAutokuca.PrijavljeniKorisnik.Uloga == Uloge.Zaposlenik)
                    {
                        btnSkladisteIEvidencija.Text = "Skladište i evidencija";
                    }
                    else
                    {
                        btnSkladisteIEvidencija.Text = "Moje gume";
                    }
                }  
            }
            else
            {
                gboxSkladiste.Visible = false;
            }
        }

        private void FrmGlavniIzbornik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                string path = System.IO.Directory.GetCurrentDirectory();
                string putanja = path.Remove(path.Length - 10);
                Help.ShowHelp(this, "file://" + putanja + "\\Autokuca-Help.chm", HelpNavigator.Topic, "Glavni izbornik.htm");
            }
        }
    }
}

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
using AdreseLib;

namespace PI_Projekt_Autokuca
{
    public partial class FrmRezervacijaTermina : Form
    {
        public bool ProbnaVoznja { get; }
        public Adrese OdabranaLokacija { get; set; }

        public FrmRezervacijaTermina(Adrese odabranaLokacija = null)
        {
            InitializeComponent();
            OdabranaLokacija = odabranaLokacija;
        }

        public FrmRezervacijaTermina(bool probnaVoznja)
        {
            InitializeComponent();
            ProbnaVoznja = probnaVoznja;
            
        }

        private void FrmRezervacijaTermina_Load(object sender, EventArgs e)
        {
            PopuniComboBoxeve();
            if (ProbnaVoznja)
            {
                dgvMojeRezervacije.DataSource = RepozitorijAutokuca.DohvatiRezervacijeKorisnika(ProbnaVoznja);
                lblMojeRezervacije.Text = "Moje rezervacije termina probnih vožnji:";
            }
            else
            {
                dgvMojeRezervacije.DataSource = RepozitorijAutokuca.DohvatiRezervacijeKorisnika(false);
                lblMojeRezervacije.Text = "Moje rezervacije termina servisa:";
            }
            UrediDataGridPrikaz();
        }
        private void PopuniComboBoxeve()
        {
            if (ProbnaVoznja)
            {
                cmbVozilo.DataSource = RepozitorijAutokuca.DohvatiVozila(ProbnaVoznja);
                cmbPredmetRezervacije.Text = "Probna vožnja";
                cmbPredmetRezervacije.Enabled = false;
                cmbLokacija.DataSource = RepozitorijAutokuca.DohvatiLokacije(ProbnaVoznja);
            }
            else
            {
                cmbVozilo.DataSource = RepozitorijAutokuca.DohvatiVozila(false);
                cmbPredmetRezervacije.DataSource = RepozitorijAutokuca.DohvatiPredmeteRezervacije();
                cmbLokacija.DataSource = RepozitorijAutokuca.DohvatiLokacije(false);
                if (OdabranaLokacija != null)
                {
                    cmbLokacija.Text = OdabranaLokacija.ToString();
                }
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbLokacija_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvTermini.Rows.Clear();
            List<TimeSpan> sati = new List<TimeSpan>();
            Adrese trenutna = cmbLokacija.SelectedItem as Adrese;
            TimeSpan? pocetak = trenutna.RadnoVrijemeOd;
            TimeSpan? kraj = trenutna.RadnoVrijemeDo;
            int pocetakSat = int.Parse(pocetak.Value.TotalHours.ToString());
            int krajSat = int.Parse(kraj.Value.TotalHours.ToString());

            for (int i = pocetakSat; i < krajSat; i++)
            {
                TimeSpan novi = new TimeSpan(i, 0, 0);
                sati.Add(novi);
                this.dgvTermini.Rows.Add(i, "");
            }
            cmbSat.DataSource = sati;
            OsvjeziDostupnostTermina();
        }

        private void mcOdabirDatuma_DateChanged(object sender, DateRangeEventArgs e)
        {
            OsvjeziDostupnostTermina();
        }
        private void OsvjeziDostupnostTermina()
        {
            DateTime odabraniDatum = mcOdabirDatuma.SelectionRange.Start;
            Adrese trenutna = cmbLokacija.SelectedItem as Adrese;
            Vozila odabranoVozilo = cmbVozilo.SelectedItem as Vozila;
            List<Rezervacije> rezervacije;

            if (ProbnaVoznja)
            {
                rezervacije = RepozitorijAutokuca.DohvatiRezervacije(odabraniDatum, trenutna, odabranoVozilo);
            }
            else
            {
                rezervacije = RepozitorijAutokuca.DohvatiRezervacije(odabraniDatum, trenutna, null);
            }

            foreach (DataGridViewRow red in dgvTermini.Rows)
            {
                red.Cells[1].Style.BackColor = Color.Green;
                int sati1 = int.Parse(red.Cells[0].Value.ToString());
                TimeSpan zaDodati = new TimeSpan(sati1, 0, 0);
                DateTime usporedba = odabraniDatum.Add(zaDodati);
                foreach (Rezervacije rezervacija in rezervacije)
                {
                    if (DateTime.Compare(rezervacija.PocetakRezervacije, usporedba) == 0)
                    {
                        red.Cells[1].Style.BackColor = Color.Red;
                    }
                }
            }
        }
        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            DateTime odabraniDatum = mcOdabirDatuma.SelectionRange.Start;
            TimeSpan trajanje = new TimeSpan(1, 0, 0);
            TimeSpan? odabraniSat = cmbSat.SelectedItem as TimeSpan?;
            TimeSpan zaDodati = new TimeSpan(int.Parse(odabraniSat.Value.TotalHours.ToString()), 0, 0);
            DateTime pocetak = odabraniDatum.Add(zaDodati);
            Adrese trenutna = cmbLokacija.SelectedItem as Adrese;
            Vozila vozilo = cmbVozilo.SelectedItem as Vozila;

            if (RepozitorijAutokuca.ProvjeriIspravnostRezervacije(odabraniDatum, pocetak, trenutna, vozilo, ProbnaVoznja)) {
                string predmetRezervacije = "";
                if (ProbnaVoznja)
                {
                    predmetRezervacije = "Probna vožnja";
                }
                else
                {
                    predmetRezervacije = cmbPredmetRezervacije.SelectedItem.ToString();
                }
                Rezervacije nova = new Rezervacije()
                {
                    DatumIVrijeme = odabraniDatum,
                    Korisnik = RepozitorijAutokuca.PrijavljeniKorisnik,
                    KrajRezervacije = pocetak.Add(trajanje),
                    PocetakRezervacije = pocetak,
                    Podruznica = trenutna,
                    PredmetRezervacije = predmetRezervacije,
                    Status = "U postupku",
                    Vozilo = cmbVozilo.SelectedItem as Vozila
                };
                RepozitorijAutokuca.KreirajRezervaciju(nova);
                dgvMojeRezervacije.DataSource = null;
                if (ProbnaVoznja)
                {
                    dgvMojeRezervacije.DataSource = RepozitorijAutokuca.DohvatiRezervacijeKorisnika(ProbnaVoznja);
                }
                else
                {
                    dgvMojeRezervacije.DataSource = RepozitorijAutokuca.DohvatiRezervacijeKorisnika(false);
                }
                UrediDataGridPrikaz();
                OsvjeziDostupnostTermina();
            }
        }
        private void UrediDataGridPrikaz()
        {
            dgvMojeRezervacije.Columns[0].Visible = false;
            dgvMojeRezervacije.Columns[2].HeaderText = "Datum";
            dgvMojeRezervacije.Columns[3].HeaderText = "Predmet";
            dgvMojeRezervacije.Columns[4].HeaderText = "Početak (sati)";
            dgvMojeRezervacije.Columns[5].HeaderText = "Kraj (sati)";
            dgvMojeRezervacije.Columns[6].Visible = false;
            dgvMojeRezervacije.Columns[8].HeaderText = "Lokacija";
        }

        private void cmbVozilo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProbnaVoznja)
            {
                if (dgvTermini.Rows.Count > 0)
                {
                    OsvjeziDostupnostTermina();
                }
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            if (dgvMojeRezervacije.CurrentRow != null)
            {
                Rezervacije odabrana = dgvMojeRezervacije.CurrentRow.DataBoundItem as Rezervacije;
                RepozitorijAutokuca.ObrisiRezervaciju(odabrana);

                if (ProbnaVoznja)
                {
                    dgvMojeRezervacije.DataSource = RepozitorijAutokuca.DohvatiRezervacijeKorisnika(ProbnaVoznja);
                    lblMojeRezervacije.Text = "Moje rezervacije termina probnih vožnji:";
                }
                else
                {
                    dgvMojeRezervacije.DataSource = RepozitorijAutokuca.DohvatiRezervacijeKorisnika(false);
                    lblMojeRezervacije.Text = "Moje rezervacije termina servisa:";
                }
                UrediDataGridPrikaz();
                OsvjeziDostupnostTermina();
            }
            else
            {
                MessageBox.Show("Nije odabrana rezervacija!");
            }
        }

        private void dgvMojeRezervacije_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMojeRezervacije.DataSource != null)
            {
                Rezervacije odabrana = dgvMojeRezervacije.CurrentRow.DataBoundItem as Rezervacije;
                if (odabrana.DatumIVrijeme.DayOfYear <= DateTime.Now.DayOfYear)
                {
                    btnOtkazi.Enabled = false;
                }
                else
                {
                    btnOtkazi.Enabled = true;
                }
            }
            
        }

        private void FrmRezervacijaTermina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                string path = System.IO.Directory.GetCurrentDirectory();
                string putanja = path.Remove(path.Length - 10);
                Help.ShowHelp(this, "file://" + putanja + "\\Autokuca-Help.chm", HelpNavigator.Topic, "Rezervacija termina.htm");
            }
        }
    }
}

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
    public partial class FrmRezervacijaTermina : Form
    {
        public FrmRezervacijaTermina()
        {
            InitializeComponent();
        }

        private void FrmRezervacijaTermina_Load(object sender, EventArgs e)
        {
            PopuniComboBoxeve();
            dgvMojeRezervacije.DataSource = RepozitorijAutokuca.DohvatiRezervacijeKorisnika();
        }
        private void PopuniComboBoxeve()
        {
            cmbVozilo.DataSource = RepozitorijAutokuca.DohvatiVozilaKorisnika();
            cmbPredmetRezervacije.DataSource = RepozitorijAutokuca.DohvatiPredmeteRezervacije();
            cmbLokacija.DataSource = RepozitorijAutokuca.DohvatiLokacije();
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
            //za data grid
            DateTime odabraniDatum = mcOdabirDatuma.SelectionRange.Start;
            List<Rezervacije> rezervacije = RepozitorijAutokuca.DohvatiRezervacije(odabraniDatum, trenutna);
            for (int i = pocetakSat; i < krajSat; i++)
            {
                TimeSpan novi = new TimeSpan(i, 0, 0);
                sati.Add(novi);
                this.dgvTermini.Rows.Add(i, "");
            }
            cmbSat.DataSource = sati;
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

        private void mcOdabirDatuma_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime odabraniDatum = mcOdabirDatuma.SelectionRange.Start;
            Adrese trenutna = cmbLokacija.SelectedItem as Adrese;
        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            DateTime odabraniDatum = mcOdabirDatuma.SelectionRange.Start;
            TimeSpan trajanje = new TimeSpan(1, 0, 0);
            TimeSpan? odabraniSat = cmbSat.SelectedItem as TimeSpan?;
            TimeSpan zaDodati = new TimeSpan(int.Parse(odabraniSat.Value.TotalHours.ToString()), 0, 0);
            DateTime pocetak = odabraniDatum.Add(zaDodati);
            Rezervacije nova = new Rezervacije()
            {
                DatumIVrijeme = odabraniDatum,
                Korisnik = RepozitorijAutokuca.PrijavljeniKorisnik,
                KrajRezervacije = pocetak.Add(trajanje),
                PocetakRezervacije = pocetak,
                Podruznica = cmbLokacija.SelectedItem as Adrese,
                PredmetRezervacije = cmbPredmetRezervacije.SelectedItem.ToString(),
                Status = "U postupku",
                Vozilo = cmbVozilo.SelectedItem as Vozila
            };
            RepozitorijAutokuca.KreirajRezervaciju(nova);
            dgvMojeRezervacije.DataSource = null;
            dgvMojeRezervacije.DataSource = RepozitorijAutokuca.DohvatiRezervacijeKorisnika();
        }
    }
}

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
            }
            cmbSat.DataSource = sati;

            //data grid
        }

        private void mcOdabirDatuma_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}

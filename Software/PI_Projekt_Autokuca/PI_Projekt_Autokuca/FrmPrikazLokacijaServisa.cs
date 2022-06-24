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
using PI_Projekt_Autokuca.Iznimke;

namespace PI_Projekt_Autokuca
{
    public partial class FrmPrikazLokacijaServisa : Form
    {
        public FrmPrikazLokacijaServisa()
        {
            InitializeComponent();
        }

        private void FrmPrikazLokacijaServisa_Load(object sender, EventArgs e)
        {
            dgvLokacije.DataSource = RepozitorijAutokuca.DohvatiLokacijeServisa();
            OsvjeziDataGridPrikaz();

            btnNovaLokacija.Visible = false;
            btnAzuriraj.Visible = false;
            btnIzbrisi.Visible = false;

            if (RepozitorijAutokuca.PrijavljeniKorisnik != null)
            {
                if (RepozitorijAutokuca.PrijavljeniKorisnik.Uloga == Uloge.Administrator)
                {
                    btnNovaLokacija.Visible = true;
                    btnAzuriraj.Visible = true;
                    btnIzbrisi.Visible = true;
                }
            }
            else
            {
                btnRezerviraj.Visible = false;
            }
        }
        private void OsvjeziDataGridPrikaz()
        {
            dgvLokacije.Columns[0].Visible = false;
            dgvLokacije.Columns[6].Visible = false;
            dgvLokacije.Columns[4].HeaderText = "Naziv podružnice";
            dgvLokacije.Columns[5].HeaderText = "Poštanski broj";
            dgvLokacije.Columns[7].HeaderText = "Početak radnog vremena";
            dgvLokacije.Columns[8].HeaderText = "Kraj radnog vremena";
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            string pretraga = txtPretraga.Text.ToLower();
            dgvLokacije.DataSource = null;
            dgvLokacije.DataSource = RepozitorijAutokuca.DohvatiLokacijeServisa(pretraga);
            OsvjeziDataGridPrikaz();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLokacije.CurrentRow != null)
                {
                    Adrese odabrana = dgvLokacije.CurrentRow.DataBoundItem as Adrese;
                    FrmRezervacijaTermina form = new FrmRezervacijaTermina(odabrana);
                    form.ShowDialog();
                }
                else
                {
                    throw new LocationNotSelectedException("Nije odabrana lokacija!");
                }
            }
            catch (LocationNotSelectedException iznimkaLokacije)
            {
                MessageBox.Show(iznimkaLokacije.Obavijest);
            }
        }

        private void btnNovaLokacija_Click(object sender, EventArgs e)
        {
            FrmDodajAzurirajLokaciju form = new FrmDodajAzurirajLokaciju();
            form.ShowDialog();
            OsvjeziPodatke();
            OsvjeziDataGridPrikaz();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLokacije.CurrentRow != null)
                {
                    Adrese odabrana = dgvLokacije.CurrentRow.DataBoundItem as Adrese;
                    FrmDodajAzurirajLokaciju form = new FrmDodajAzurirajLokaciju(true, odabrana);
                    form.ShowDialog();
                }
                else
                {
                    throw new LocationNotSelectedException("Nije odabrana lokacija!");
                }
            }
            catch (LocationNotSelectedException iznimkaLokacije)
            {
                MessageBox.Show(iznimkaLokacije.Obavijest);
            }

            OsvjeziPodatke();
            OsvjeziDataGridPrikaz();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLokacije.CurrentRow != null)
                {
                    Adrese odabrana = dgvLokacije.CurrentRow.DataBoundItem as Adrese;
                    RepozitorijAutokuca.ObrisiLokaciju(odabrana);
                }
                else
                {
                    throw new LocationNotSelectedException("Nije odabrana lokacija!");
                }
            }
            catch (LocationNotSelectedException iznimkaLokacije)
            {
                MessageBox.Show(iznimkaLokacije.Obavijest);
            }
            OsvjeziPodatke();
            OsvjeziDataGridPrikaz();
        }
        private void OsvjeziPodatke()
        {
            dgvLokacije.DataSource = null;
            dgvLokacije.DataSource = RepozitorijAutokuca.DohvatiLokacijeServisa();
        }
    }
}

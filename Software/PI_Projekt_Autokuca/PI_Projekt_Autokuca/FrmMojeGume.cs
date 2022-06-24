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
    public partial class FrmMojeGume : Form
    {
        public FrmMojeGume()
        {
            InitializeComponent();
        }

        private void FrmMojeGume_Load(object sender, EventArgs e)
        {
            dgvMojeGume.DataSource = RepozitorijAutokuca.DohvatiGume(RepozitorijAutokuca.PrijavljeniKorisnik);
            UrediPrikaz();
        }
        private void UrediPrikaz()
        {
            dgvMojeGume.Columns[0].Visible = false;
            dgvMojeGume.Columns[1].HeaderText = "Šifra gume";
            dgvMojeGume.Columns[2].HeaderText = "Širina";
            dgvMojeGume.Columns[5].Visible = false;
            dgvMojeGume.Columns[6].Visible = false;
            dgvMojeGume.Columns[7].HeaderText = "Količina na skladištu";
            dgvMojeGume.Columns[8].Visible = false;
            dgvMojeGume.Columns[9].HeaderText = "Proizvođač";
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

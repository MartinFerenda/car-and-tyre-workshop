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
    public partial class FrmSkladisteIEvidencija : Form
    {
        public FrmSkladisteIEvidencija()
        {
            InitializeComponent();
        }

        private void FrmSkladisteIEvidencija_Load(object sender, EventArgs e)
        {
            dgvGume.DataSource = RepozitorijAutokuca.DohvatiGume();
            UrediPrikazGume();
            dgvDijelovi.DataSource = RepozitorijAutokuca.DohvatiDijelove();
            UrediPrikazDijelova();
        }

        private void txtPretragaGuma_TextChanged(object sender, EventArgs e)
        {
            dgvGume.DataSource = null;
            dgvGume.DataSource = RepozitorijAutokuca.DohvatiGume(null, txtPretragaGuma.Text);
            UrediPrikazGume();
        }
        private void UrediPrikazGume()
        {
            dgvGume.Columns[0].Visible = false;
            dgvGume.Columns[1].HeaderText = "Šifra gume";
            dgvGume.Columns[2].HeaderText = "Širina";
            dgvGume.Columns[5].HeaderText = "Nabavna cijena (HRK)";
            dgvGume.Columns[6].HeaderText = "Prodajna cijena (HRK)";
            dgvGume.Columns[7].HeaderText = "Količina na skladištu";
            dgvGume.Columns[8].HeaderText = "Vlasnik";
            dgvGume.Columns[9].HeaderText = "Proizvođač";
        }
        private void UrediPrikazDijelova()
        {
            dgvDijelovi.Columns[0].HeaderText = "Šifra dijela";
            dgvDijelovi.Columns[3].HeaderText = "Nabavna cijena (HRK)";
            dgvDijelovi.Columns[4].HeaderText = "Prodajna cijena (HRK)";
            dgvDijelovi.Columns[5].HeaderText = "Količina na skladištu";
            dgvDijelovi.Columns[6].HeaderText = "Proizvođač";
        }

        private void txtPretragaNaziv_TextChanged(object sender, EventArgs e)
        {
            dgvDijelovi.DataSource = null;
            dgvDijelovi.DataSource = RepozitorijAutokuca.DohvatiDijelove();
            UrediPrikazDijelova();
        }

        private void btnDodajDio_Click(object sender, EventArgs e)
        {
            FrmDodajAzurirajDio form = new FrmDodajAzurirajDio(false, null);
            form.ShowDialog();
        }
    }
}

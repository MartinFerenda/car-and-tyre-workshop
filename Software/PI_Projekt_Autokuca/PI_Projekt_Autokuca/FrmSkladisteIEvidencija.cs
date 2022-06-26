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
using PI_Projekt_Autokuca.Iznimke;
using SkladisteLib;

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
            dgvDijelovi.DataSource = RepozitorijAutokuca.DohvatiDijelove(txtPretragaNaziv.Text);
            UrediPrikazDijelova();
        }

        private void btnDodajDio_Click(object sender, EventArgs e)
        {
            FrmDodajAzurirajDio form = new FrmDodajAzurirajDio(false, null);
            form.ShowDialog();
            OsvjeziPrikazDijelova();
        }

        private void btnAzurirajDio_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDijelovi.CurrentRow != null)
                {
                    AutomobilskiDijelovi odabrani = dgvDijelovi.CurrentRow.DataBoundItem as AutomobilskiDijelovi;
                    FrmDodajAzurirajDio form = new FrmDodajAzurirajDio(true, odabrani);
                    form.ShowDialog();
                }
                else
                {
                    throw new WantedItemNotSelectedException("Nije odabran automobilski dio!");
                }
                
            }
            catch (WantedItemNotSelectedException ex)
            {
                MessageBox.Show(ex.Obavijest);
            }
            OsvjeziPrikazDijelova();
        }

        private void btnIzbrisiDio_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDijelovi.CurrentRow != null)
                {
                    AutomobilskiDijelovi odabrani = dgvDijelovi.CurrentRow.DataBoundItem as AutomobilskiDijelovi;
                    RepozitorijAutokuca.ObrisiDio(odabrani);
                }
                else
                {
                    throw new WantedItemNotSelectedException("Nije odabran automobilski dio!");
                }

            }
            catch (WantedItemNotSelectedException ex)
            {
                MessageBox.Show(ex.Obavijest);
            }
            OsvjeziPrikazDijelova();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodajKolDio_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDijelovi.CurrentRow != null)
                {
                    AutomobilskiDijelovi odabrani = dgvDijelovi.CurrentRow.DataBoundItem as AutomobilskiDijelovi;
                    int kolicina = int.Parse(txtPromjenaKolicineDio.Text);
                    if (kolicina < 0)
                    {
                        MessageBox.Show("Nije unesena ispravna količina!");
                    }
                    else
                    {
                        odabrani.KolicinaNaSkladistu += kolicina;
                        RepozitorijAutokuca.AzurirajAutomobilskiDio(odabrani);
                        OsvjeziPrikazDijelova();
                        txtPromjenaKolicineDio.Text = "";
                    } 
                }
                else
                {
                    throw new WantedItemNotSelectedException("Nije odabran automobilski dio!");
                }

            }
            catch (WantedItemNotSelectedException ex)
            {
                MessageBox.Show(ex.Obavijest);
            }
        }

        private void btnOduzmiKolDio_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDijelovi.CurrentRow != null)
                {
                    AutomobilskiDijelovi odabrani = dgvDijelovi.CurrentRow.DataBoundItem as AutomobilskiDijelovi;
                    int kolicina = int.Parse(txtPromjenaKolicineDio.Text);
                    if (kolicina < 0)
                    {
                        MessageBox.Show("Nije unesena ispravna količina!");
                    }
                    else
                    {
                        if (kolicina > odabrani.KolicinaNaSkladistu)
                        {
                            MessageBox.Show("Nedovoljna količina na skladištu!");
                        }
                        else
                        {
                            odabrani.KolicinaNaSkladistu -= kolicina;
                            RepozitorijAutokuca.AzurirajAutomobilskiDio(odabrani);
                            OsvjeziPrikazDijelova();
                            txtPromjenaKolicineDio.Text = "";
                        }
                    }
                }
                else
                {
                    throw new WantedItemNotSelectedException("Nije odabran automobilski dio!");
                }

            }
            catch (WantedItemNotSelectedException ex)
            {
                MessageBox.Show(ex.Obavijest);
            }
        }

        private void btnDodajGumu_Click(object sender, EventArgs e)
        {
            FrmDodajAzurirajGumu form = new FrmDodajAzurirajGumu();
            form.ShowDialog();
            OsvjeziPrikazGuma();
        }

        private void btnAzurirajGumu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGume.CurrentRow != null)
                {
                    Gume odabrana = dgvGume.CurrentRow.DataBoundItem as Gume;
                    FrmDodajAzurirajGumu form = new FrmDodajAzurirajGumu(odabrana);
                    form.ShowDialog();
                }
                else
                {
                    throw new WantedItemNotSelectedException("Nije odabrana guma!");
                }
            }
            catch (WantedItemNotSelectedException ex)
            {
                MessageBox.Show(ex.Obavijest);
            }
            OsvjeziPrikazGuma();
        }

        private void btnIzbrisiGumu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGume.CurrentRow != null)
                {
                    Gume odabrana = dgvGume.CurrentRow.DataBoundItem as Gume;
                    RepozitorijAutokuca.ObrisiGumu(odabrana);
                }
                else
                {
                    throw new WantedItemNotSelectedException("Nije odabrana guma!");
                }
            }
            catch (WantedItemNotSelectedException ex)
            {
                MessageBox.Show(ex.Obavijest);
            }
            OsvjeziPrikazGuma();
        }

        private void btnDodajKolGuma_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGume.CurrentRow != null)
                {
                    Gume odabrana = dgvGume.CurrentRow.DataBoundItem as Gume;
                    if (txtPromjenaKolicineGuma.Text != "")
                    {
                        int kolicina = int.Parse(txtPromjenaKolicineGuma.Text);
                        if (kolicina > 0)
                        {
                            odabrana.KolicinaNaSkladistu += kolicina;
                            RepozitorijAutokuca.AzurirajGumu(odabrana);
                            OsvjeziPrikazGuma();
                            txtPromjenaKolicineGuma.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Nije unesena ispravna količina!");
                        }
                    }
                }
                else
                {
                    throw new WantedItemNotSelectedException("Nije odabrana guma!");
                }
            }
            catch (WantedItemNotSelectedException ex)
            {
                MessageBox.Show(ex.Obavijest);
            } 
        }
        private void OsvjeziPrikazGuma()
        {
            dgvGume.DataSource = null;
            dgvGume.DataSource = RepozitorijAutokuca.DohvatiGume();
            UrediPrikazGume();
        }
        private void OsvjeziPrikazDijelova()
        {
            dgvDijelovi.DataSource = null;
            dgvDijelovi.DataSource = RepozitorijAutokuca.DohvatiDijelove();
            UrediPrikazDijelova();
        }

        private void btnOduzmiKolGuma_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGume.CurrentRow != null)
                {
                    Gume odabrana = dgvGume.CurrentRow.DataBoundItem as Gume;
                    if (txtPromjenaKolicineGuma.Text != "")
                    {
                        int kolicina = int.Parse(txtPromjenaKolicineGuma.Text);
                        if (kolicina > 0)
                        {
                            if (kolicina > odabrana.KolicinaNaSkladistu)
                            {
                                MessageBox.Show("Nedovoljna količina na skladištu!");
                            }
                            else
                            {
                                odabrana.KolicinaNaSkladistu -= kolicina;
                                RepozitorijAutokuca.AzurirajGumu(odabrana);
                                OsvjeziPrikazGuma();
                                txtPromjenaKolicineGuma.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nije unesena ispravna količina!");
                        }
                    }
                }
                else
                {
                    throw new WantedItemNotSelectedException("Nije odabrana guma!");
                }
            }
            catch (WantedItemNotSelectedException ex)
            {
                MessageBox.Show(ex.Obavijest);
            }
        }
    }
}

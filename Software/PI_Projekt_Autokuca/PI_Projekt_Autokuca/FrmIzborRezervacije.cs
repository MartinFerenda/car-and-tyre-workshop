using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Projekt_Autokuca
{
    public partial class FrmIzborRezervacije : Form
    {
        public FrmIzborRezervacije()
        {
            InitializeComponent();
        }

        private void Proba_Load(object sender, EventArgs e)
        {

        }

        private void btnRezervirajServis_Click(object sender, EventArgs e)
        {
            FrmRezervacijaTermina form = new FrmRezervacijaTermina();
            form.ShowDialog();
        }

        private void btnRezervirajProbnuVoznju_Click(object sender, EventArgs e)
        {
            bool probnaVoznja = true;
            FrmRezervacijaTermina form = new FrmRezervacijaTermina(probnaVoznja);
            form.ShowDialog();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

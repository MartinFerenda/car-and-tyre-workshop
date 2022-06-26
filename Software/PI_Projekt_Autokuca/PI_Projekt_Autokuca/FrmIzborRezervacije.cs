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
            this.KeyPreview = true;

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

        private void FrmIzborRezervacije_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                string path = System.IO.Directory.GetCurrentDirectory();
                string putanja = path.Remove(path.Length - 10);
                Help.ShowHelp(this, "file://" + putanja + "\\Autokuca-Help.chm", HelpNavigator.Topic, "Izbor rezervacije.htm");
            }
        }
    }
}

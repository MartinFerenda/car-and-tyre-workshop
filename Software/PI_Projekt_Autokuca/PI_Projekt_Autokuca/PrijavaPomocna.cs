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
    public partial class PrijavaPomocna : Form
    {
        public PrijavaPomocna()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            RepozitorijAutokuca.PrijaviKorisnika(txtKorisnickoIme.Text, txtLozinka.Text);
            if (RepozitorijAutokuca.PrijavljeniKorisnik != null)
            {
                Close();
            }
        }

        private void PrijavaPomocna_Load(object sender, EventArgs e)
        {

        }
    }
}

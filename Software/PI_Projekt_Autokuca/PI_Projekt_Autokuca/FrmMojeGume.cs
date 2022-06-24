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
    public partial class FrmMojeGume : Form
    {
        public FrmMojeGume()
        {
            InitializeComponent();
        }

        private void FrmMojeGume_Load(object sender, EventArgs e)
        {

        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

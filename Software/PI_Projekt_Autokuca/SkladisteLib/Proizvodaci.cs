using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladisteLib
{
    public class Proizvodaci
    {
        public int IDProizvodaca { get; set; }
        public string Naziv { get; set; }
        public string Kontakt { get; set; }
        public Proizvodaci(int iDProizvodaca, string naziv, string kontakt)
        {
            IDProizvodaca = iDProizvodaca;
            Naziv = naziv;
            Kontakt = kontakt;
        }
        public override string ToString()
        {
            return Naziv;
        }
    }
}

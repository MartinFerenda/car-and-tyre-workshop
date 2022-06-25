using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladisteLib
{
    public class Vlasnik
    {
        public int IdVlasnika { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Vlasnik()
        {

        }
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladisteLib
{
    public class Gume
    {
        public int IDGume { get; set; }
        public int SifraGume { get; set; }
        public int Sirina { get; set; }
        public int Visina { get; set; }
        public int Promjer { get; set; }
        public decimal NabavnaCijena { get; set; }
        public decimal ProdajnaCijena { get; set; }
        public int KolicinaNaSkladistu { get; set; }
        public int Korisnik { get; set; }
        public Proizvodaci Proizvodac { get; set; }
    }
}

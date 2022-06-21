using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Projekt_Autokuca.Klase
{
    public class Guma
    {
        public int IDGume { get; set; }
        public int SifraGume { get; set; }
        public int Sirina { get; set; }
        public int Visina { get; set; }
        public int Promjer { get; set; }
        public decimal NabavnaCijena { get; set; }
        public decimal ProdajnaCijena { get; set; }
        public int KolicinaNaSkladistu { get; set; }
        public Korisnik Korisnik { get; set; }
        public Proizvodac Proizvodac { get; set; }

    }
}

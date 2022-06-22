using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Projekt_Autokuca.Klase
{
    public class AutomobilskiDijelovi
    {
        public int SifraDijela { get; set; }
        public string Naziv { get; set; }
        public bool Original { get; set; }
        public decimal NabavnaCijena { get; set; }
        public decimal ProdajnaCijena { get; set; }
        public int KolicinaNaSkladistu { get; set; }
        public Proizvodaci Proizvodac { get; set; }
    }
}

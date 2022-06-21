using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Projekt_Autokuca.Klase
{
    public class TestVoznja
    {
        public int IDTestVoznje { get; set; }
        public string Opis { get; set; }
        public DateTime DatumIVrijeme { get; set; }
        public Vozilo Vozilo { get; set; }
        public Korisnik Korisnik { get; set; }
    }
}

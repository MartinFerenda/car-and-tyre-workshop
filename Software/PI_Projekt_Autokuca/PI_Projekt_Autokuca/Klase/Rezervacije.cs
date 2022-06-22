using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Projekt_Autokuca.Klase
{
    public class Rezervacije
    {
        public int IDRezervacije { get; set; }
        public string Status { get; set; }
        public DateTime DatumIVrijeme { get; set; }
        public string PredmetRezervacije { get; set; }
        public DateTime PocetakRezervacije { get; set; }
        public DateTime KrajRezervacije { get; set; }
        public Korisnici Korisnik { get; set; }
        public Vozila Vozilo { get; set; }
        public Adrese Podruznica { get; set; }
    }
}

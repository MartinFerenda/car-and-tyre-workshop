using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Projekt_Autokuca.Klase
{
    public class Rezervacija
    {
        public int IDRezervacije { get; set; }
        public string Status { get; set; }
        public DateTime DatumIVrijeme { get; set; }
        public string PredmetRezervacije { get; set; }
        public DateTime PocetakRezervacije { get; set; }
        public DateTime KrajRezervacije { get; set; }
        public Korisnik Korisnik { get; set; }
        public Vozilo Vozilo { get; set; }
        public Adresa Podruznica { get; set; }
    }
}

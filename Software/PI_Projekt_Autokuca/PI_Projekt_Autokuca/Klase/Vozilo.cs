using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Projekt_Autokuca.Klase
{
    public class Vozilo
    {
        public int IDVozila { get; set; }
        public string RegistarskaOznaka { get; set; }
        public string Status { get; set; }
        public decimal Cijena { get; set; }
        public int GodineJamstva { get; set; }
        public int GodinaProizvodnje { get; set; }
        public int SnagaMotora { get; set; }
        public int StupanjMjenjaca { get; set; }
        public string Boja { get; set; }
        public int BrojPrijedenihKilometara { get; set; }
        public Marka Marka { get; set; }
        public Korisnik Vlasnik { get; set; }
        public VrstaVozilo Vrsta { get; set; }
        public VrstaGorivo Gorivo { get; set; }

    }
}

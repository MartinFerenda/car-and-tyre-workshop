using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Projekt_Autokuca.Klase
{
    public class Korisnik
    {
        public int IDKorisnik { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Kontakt { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public Uloga Uloga { get; set; }
        public Adresa Adresa { get; set; }
        public Korisnik()
        {

        }
    }
}

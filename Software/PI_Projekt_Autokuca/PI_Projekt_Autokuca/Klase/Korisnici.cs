using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdreseLib;

namespace PI_Projekt_Autokuca.Klase
{
    public class Korisnici
    {
        public int IDKorisnik { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Kontakt { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public Uloge Uloga { get; set; }
        public Adrese Adresa { get; set; }
        public Korisnici()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Projekt_Autokuca.Klase
{
    public class Racun
    {
        public int IDRacuna { get; set; }
        public DateTime DatumIVrijeme { get; set; }
        public Zaposlenik Zaposlenik { get; set; }
        public string Opis { get; set; }
        public decimal Iznos { get; set; }
        public Korisnik Korisnik { get; set; }
        public Servis Servis { get; set; }
        public NacinPlacanja NacinPlacanja { get; set; }
    }
}

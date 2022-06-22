using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Projekt_Autokuca.Klase
{
    public class Racuni
    {
        public int IDRacuna { get; set; }
        public DateTime DatumIVrijeme { get; set; }
        public Zaposlenici Zaposlenik { get; set; }
        public string Opis { get; set; }
        public decimal Iznos { get; set; }
        public Korisnici Korisnik { get; set; }
        public Servisi Servis { get; set; }
        public NaciniPlacanja NacinPlacanja { get; set; }
    }
}

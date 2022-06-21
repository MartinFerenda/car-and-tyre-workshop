using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Projekt_Autokuca.Klase
{
    public class Servis
    {
        public int IDServisa { get; set; }
        public string Opis { get; set; }
        public DateTime DatumIVrijeme { get; set; }
        public int SatiRada { get; set; }
        public decimal CijenaSatnice { get; set; }
        public Zaposlenik Zaposlenik { get; set; }
        public Vozilo Vozilo { get; set; }
    }
}

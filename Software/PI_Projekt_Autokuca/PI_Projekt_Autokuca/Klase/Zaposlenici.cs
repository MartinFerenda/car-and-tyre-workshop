using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdreseLib;

namespace PI_Projekt_Autokuca.Klase
{
    public class Zaposlenici
    {
        public int IDZaposlenika { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Kontakt { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public string RadnoMjesto { get; set; }
        public Adrese Adresa { get; set; }
        public Adrese Podruznica { get; set; }
    }
}

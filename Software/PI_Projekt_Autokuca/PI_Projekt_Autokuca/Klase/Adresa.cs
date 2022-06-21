using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Projekt_Autokuca.Klase
{
    public class Adresa
    {
        public int IDAdrese { get; set; }
        public string Broj { get; set; }
        public string Ulica { get; set; }
        public string Mjesto { get; set; }
        public string PostanskiBroj { get; set; }
        public string OpisPodruznice { get; set; }
        public TimeSpan RadnoVrijemeOd { get; set; }
        public TimeSpan RadnoVrijemeDo { get; set; }
    }
}

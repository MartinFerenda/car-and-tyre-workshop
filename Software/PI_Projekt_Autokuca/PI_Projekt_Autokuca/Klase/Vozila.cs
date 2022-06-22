using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Projekt_Autokuca.Klase
{
    public partial class Vozila
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
        public Marke Marka { get; set; }
        public Korisnici Vlasnik { get; set; }
        public VrsteVozila Vrsta { get; set; }
        public VrsteGoriva Gorivo { get; set; }

        public override string ToString()
        {
            return RegistarskaOznaka + " " + Marka.NazivMarkeIModel;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PI_Projekt_Autokuca.Baza;

namespace PI_Projekt_Autokuca.Klase
{
    public static class RepozitorijAutokuca
    {
        public static Korisnici PrijavljeniKorisnik { get; set; }
        public static void PrijaviKorisnika()
        {

        }
        public static List<Vozila> DohvatiVozilaKorisnika()
        {
            List<Vozila> vozila = new List<Vozila>();
            foreach (Vozilo vozilo in DohvatiSvaVozila())
            {
                Vozila novo = new Vozila()
                {
                    Boja = vozilo.Boja,
                    BrojPrijedenihKilometara = vozilo.BrojPrijedenihKilometara,
                    GodinaProizvodnje = vozilo.GodinaProizvodnje,
                    Gorivo = DohvatiGorivo(vozilo),
                    IDVozila = vozilo.IdVozila,
                    Marka = DohvatiMarku(vozilo),
                    RegistarskaOznaka = vozilo.RegistraskaOznaka,
                    SnagaMotora = vozilo.SnagaMotora,
                    Status = vozilo.Status,
                    StupanjMjenjaca = vozilo.StupanjMjenjaca,
                    Vrsta = DohvatiVrstu(vozilo)
                };
                vozila.Add(novo);
            }
            return vozila;
        }
        public static List<Vozilo> DohvatiSvaVozila()
        {
            using (var context = new PI2227_DBEntities())
            {
                return context.Voziloes.ToList();
            }
        }
        public static VrsteGoriva DohvatiGorivo(Vozilo vozilo)
        {
            using (var context = new PI2227_DBEntities())
            {
                context.Voziloes.Attach(vozilo);
                VrsteGoriva novo = new VrsteGoriva()
                {
                    IDGorivo = vozilo.Gorivo,
                    Naziv = vozilo.VrstaGoriva.Naziv
                };
                return novo;
            }
        }
        public static Marke DohvatiMarku(Vozilo vozilo)
        {
            using (var context = new PI2227_DBEntities())
            {
                context.Voziloes.Attach(vozilo);
                Marke novo = new Marke()
                {
                    IDMarke = vozilo.Marka,
                    NazivMarkeIModel = vozilo.MarkaVozila.NazivMarkeIModela
                };
                return novo;
            }
        }
        public static VrsteVozila DohvatiVrstu(Vozilo vozilo)
        {
            using (var context = new PI2227_DBEntities())
            {
                context.Voziloes.Attach(vozilo);
                VrsteVozila novo = new VrsteVozila()
                {
                    IDVrsteVozila = vozilo.Vrsta,
                    Naziv = vozilo.VrstaVozila.Naziv,
                };
                return novo;
            }
        }
        public static List<string> DohvatiPredmeteRezervacije()
        {
            List<string> predmeti = new List<string>();
            predmeti.Add("Redovan servis");
            predmeti.Add("Dodatna oprema");
            predmeti.Add("Popravak limarije");
            predmeti.Add("Vjetrobransko staklo");
            predmeti.Add("Ostalo");
            return predmeti;
        }
        public static List<Adrese> DohvatiLokacije()
        {
            List<Adrese> lokacije = new List<Adrese>();
            using (var context = new PI2227_DBEntities())
            {
                var query = from a in context.Adresas
                            where a.OpisPodruznice == "Servis"
                            select a;
                List<Adresa> adrese = query.ToList();
                foreach (Adresa adresa in adrese)
                {
                    Adrese nova = new Adrese()
                    {
                        Broj = adresa.Broj,
                        IDAdrese = adresa.IdAdrese,
                        Mjesto = adresa.Mjesto,
                        NazivPodruznice = adresa.NazivPodruznice,
                        OpisPodruznice = adresa.OpisPodruznice,
                        PostanskiBroj = adresa.PostanskiBroj,
                        RadnoVrijemeDo = adresa.RadnoVrijemeDo,
                        RadnoVrijemeOd = adresa.RadnoVrijemeOd,
                        Ulica = adresa.Ulica
                    };
                    lokacije.Add(nova);
                }
                return lokacije;
            }
        }
    }
}

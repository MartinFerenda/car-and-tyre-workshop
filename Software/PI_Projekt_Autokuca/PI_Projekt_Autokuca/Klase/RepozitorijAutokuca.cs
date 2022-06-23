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

        public static void PrijaviKorisnika(string korisnickoIme, string lozinka)
        {
            if (korisnickoIme == "mzidaric" && lozinka == "sudo123")
            {
                Korisnici prijavljen = new Korisnici()
                {
                    IDKorisnik = 1,
                    Uloga = Uloge.NeregistriraniKorisnik
                };
                PrijavljeniKorisnik = prijavljen;
                return;
            }
            if (korisnickoIme == "tstancin" && lozinka == "v1do123")
            {
                Korisnici prijavljen = new Korisnici()
                {
                    IDKorisnik = 2,
                    Uloga = Uloge.RegistriraniKorisnik
                };
                PrijavljeniKorisnik = prijavljen;
                return;
            }
            if (korisnickoIme == "nzugec" && lozinka == "iinproj3kt")
            {
                Korisnici prijavljen = new Korisnici()
                {
                    IDKorisnik = 3,
                    Uloga = Uloge.Zaposlenik
                };
                PrijavljeniKorisnik = prijavljen;
                return;
            }
            if (korisnickoIme == "mferenda" && lozinka == "mf3r3nda")
            {
                Korisnici prijavljen = new Korisnici()
                {
                    IDKorisnik = 4,
                    Uloga = Uloge.Administrator
                };
                PrijavljeniKorisnik = prijavljen;
                return;
            }
        }
        public static List<Vozila> DohvatiVozilaKorisnika()
        {
            List<Vozila> vozila = new List<Vozila>();
            foreach (Vozilo vozilo in DohvatiSvaVozila())
            {
                if (vozilo.Vlasnik == PrijavljeniKorisnik.IDKorisnik) {
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
        public static List<Rezervacije> DohvatiRezervacije(DateTime datum, Adrese adresa)
        {
            List<Rezervacije> vrati = new List<Rezervacije>();
            List<Rezervacija> odabrane = new List<Rezervacija>();
            using (var context = new PI2227_DBEntities())
            {
                var query = from r in context.Rezervacijas
                            where r.Adresa == adresa.IDAdrese && r.DatumIVrijeme == datum
                            select r;
                odabrane = query.ToList();
                foreach (Rezervacija rezervacija in odabrane)
                {
                    Rezervacije nova = new Rezervacije()
                    {
                        DatumIVrijeme = rezervacija.DatumIVrijeme,
                        IDRezervacije = rezervacija.IdRezervacije,
                        KrajRezervacije = rezervacija.KrajRezervacije,
                        PocetakRezervacije = rezervacija.PocetakRezervacije,
                        PredmetRezervacije = rezervacija.PredmetRezervacije,
                        Status = rezervacija.Status,
                    };
                    vrati.Add(nova);
                }
                return vrati;
            }
        }
        public static List<Rezervacije> DohvatiRezervacijeKorisnika() 
        {
            List<Rezervacije> vrati = new List<Rezervacije>();
            List<Rezervacija> odabrane = new List<Rezervacija>();
            using (var context = new PI2227_DBEntities())
            {
                var query = from r in context.Rezervacijas
                            where r.Korisnik == PrijavljeniKorisnik.IDKorisnik
                            select r;
                odabrane = query.ToList();
                foreach (Rezervacija rezervacija in odabrane)
                {
                    Rezervacije nova = new Rezervacije()
                    {
                        DatumIVrijeme = rezervacija.DatumIVrijeme,
                        IDRezervacije = rezervacija.IdRezervacije,
                        KrajRezervacije = rezervacija.KrajRezervacije,
                        PocetakRezervacije = rezervacija.PocetakRezervacije,
                        PredmetRezervacije = rezervacija.PredmetRezervacije,
                        Status = rezervacija.Status,
                    };
                    vrati.Add(nova);
                }
                return vrati;
            }
        }
        public static void KreirajRezervaciju(Rezervacije novaRezervacija) 
        {
            using (var context = new PI2227_DBEntities())
            {
                Rezervacija novaRezervacijaBaza = new Rezervacija()
                {
                    Adresa = novaRezervacija.Podruznica.IDAdrese,
                    DatumIVrijeme = novaRezervacija.DatumIVrijeme,
                    Korisnik = PrijavljeniKorisnik.IDKorisnik,
                    KrajRezervacije = novaRezervacija.KrajRezervacije,
                    PocetakRezervacije = novaRezervacija.PocetakRezervacije,
                    PredmetRezervacije = novaRezervacija.PredmetRezervacije,
                    Status = novaRezervacija.Status,
                    Vozilo = novaRezervacija.Vozilo.IDVozila   
                };
                context.Rezervacijas.Add(novaRezervacijaBaza);
                context.SaveChanges();
            }
        }
    }
}

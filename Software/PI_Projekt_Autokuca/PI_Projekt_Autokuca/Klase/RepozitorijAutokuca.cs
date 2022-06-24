using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_Projekt_Autokuca.Baza;
using AdreseLib;

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
        public static List<Vozila> DohvatiVozila(bool probnaVoznja)
        {
            List<Vozila> vozila = new List<Vozila>();
            List<Vozilo> vozilos = new List<Vozilo>();
            using (var context = new PI2227_DBEntities1())
            {
                if (probnaVoznja)
                {
                    var query = from v in context.Voziloes
                                where v.Status == "Dostupno"
                                select v;
                    vozilos = query.ToList();
                }
                else
                {
                    var query = from v in context.Voziloes
                                where v.Vlasnik == PrijavljeniKorisnik.IDKorisnik
                                select v;
                    vozilos = query.ToList();
                }
                foreach (Vozilo vozilo in vozilos)
                {
                    Vozila novo = new Vozila()
                    {
                        Boja = vozilo.Boja,
                        BrojPrijedenihKilometara = vozilo.BrojPrijedenihKilometara,
                        GodinaProizvodnje = vozilo.GodinaProizvodnje,
                        Gorivo = DohvatiGorivo(vozilo.Gorivo),
                        IDVozila = vozilo.IdVozila,
                        Marka = DohvatiMarku(vozilo.Marka),
                        RegistarskaOznaka = vozilo.RegistraskaOznaka,
                        SnagaMotora = vozilo.SnagaMotora,
                        Status = vozilo.Status,
                        StupanjMjenjaca = vozilo.StupanjMjenjaca,
                        Vrsta = DohvatiVrstu(vozilo.Vrsta)
                    };
                    vozila.Add(novo);
                }
                return vozila;
            }
        }
        public static VrsteGoriva DohvatiGorivo(int idGorivo)
        {
            using (var context = new PI2227_DBEntities1())
            {
                var query = from g in context.VrstaGorivas
                            where g.IdGoriva == idGorivo
                            select g;
                VrstaGoriva vrstaGoriva = query.First();
                VrsteGoriva novo = new VrsteGoriva()
                {
                    IDGorivo = vrstaGoriva.IdGoriva,
                    Naziv = vrstaGoriva.Naziv
                };
                return novo;
            }
        }
        public static Marke DohvatiMarku(int marka)
        {
            using (var context = new PI2227_DBEntities1())
            {
                var query = from m in context.MarkaVozilas
                            where m.IdMarke == marka
                            select m;
                MarkaVozila trazena = query.First();
                Marke novo = new Marke()
                {
                    IDMarke = trazena.IdMarke,
                    NazivMarkeIModel = trazena.NazivMarkeIModela
                };
                return novo;
            }
        }
        public static VrsteVozila DohvatiVrstu(int idVrste)
        {
            using (var context = new PI2227_DBEntities1())
            {
                var query = from v in context.VrstaVozilas
                            where v.IdVrste == idVrste
                            select v;
                VrstaVozila trazena = query.First();
                VrsteVozila novo = new VrsteVozila()
                {
                    IDVrsteVozila = trazena.IdVrste,
                    Naziv = trazena.Naziv,
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
        public static List<Adrese> DohvatiLokacije(bool probnaVoznja)
        {
            List<Adrese> lokacije = new List<Adrese>();
            using (var context = new PI2227_DBEntities1())
            {
                List<Adresa> adrese;
                if (probnaVoznja)
                {
                    var query = from a in context.Adresas
                                where a.OpisPodruznice == "Autosalon"
                                select a;
                    adrese = query.ToList();
                }
                else
                {
                    var query = from a in context.Adresas
                                where a.OpisPodruznice == "Servis"
                                select a;
                    adrese = query.ToList();
                }
                foreach (Adresa adresa in adrese)
                {
                    lokacije.Add(NovaAdresa(adresa));
                }
                return lokacije;
            }
        }
        public static List<Rezervacije> DohvatiRezervacije(DateTime datum, Adrese adresa, Vozila vozilo)
        {
            List<Rezervacije> vrati = new List<Rezervacije>();
            List<Rezervacija> odabrane = new List<Rezervacija>();
            using (var context = new PI2227_DBEntities1())
            {
                if (vozilo != null)
                {
                    var query = from r in context.Rezervacijas
                                where r.Adresa == adresa.IDAdrese && r.DatumIVrijeme == datum && r.Vozilo == vozilo.IDVozila
                                select r;
                    odabrane = query.ToList();
                }
                else
                {
                    var query = from r in context.Rezervacijas
                                where r.Adresa == adresa.IDAdrese && r.DatumIVrijeme == datum
                                select r;
                    odabrane = query.ToList();
                }
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
        public static List<Rezervacije> DohvatiRezervacijeKorisnika(bool probnaVoznja) 
        {
            List<Rezervacije> vrati = new List<Rezervacije>();
            List<Rezervacija> odabrane = new List<Rezervacija>();
            List<Vozila> vozilaKorisnika = DohvatiVozila(probnaVoznja);
            List<Adrese> adrese = DohvatiLokacije(probnaVoznja);

            using (var context = new PI2227_DBEntities1())
            {
                if (probnaVoznja)
                {
                    var query = from r in context.Rezervacijas
                                where r.Korisnik == PrijavljeniKorisnik.IDKorisnik && r.PredmetRezervacije == "Probna vožnja"
                                select r;
                    odabrane = query.ToList();
                }
                else
                {
                    var query = from r in context.Rezervacijas
                                where r.Korisnik == PrijavljeniKorisnik.IDKorisnik && r.PredmetRezervacije != "Probna vožnja"
                                select r;
                    odabrane = query.ToList();
                }
                foreach (Rezervacija rezervacija in odabrane)
                {
                    foreach (Vozila vozilo in vozilaKorisnika)
                    {
                        if (vozilo.IDVozila == rezervacija.Vozilo)
                        {
                            foreach (Adrese adresa in adrese)
                            {
                                if (adresa.IDAdrese == rezervacija.Adresa)
                                {
                                    Rezervacije nova = new Rezervacije()
                                    {
                                        DatumIVrijeme = rezervacija.DatumIVrijeme,
                                        IDRezervacije = rezervacija.IdRezervacije,
                                        KrajRezervacije = rezervacija.KrajRezervacije,
                                        PocetakRezervacije = rezervacija.PocetakRezervacije,
                                        PredmetRezervacije = rezervacija.PredmetRezervacije,
                                        Status = rezervacija.Status,
                                        Vozilo = vozilo,
                                        Podruznica = adresa
                                    };
                                    vrati.Add(nova);
                                }
                            }
                        }
                    }
                }
                return vrati;
            }
        }
        public static void KreirajRezervaciju(Rezervacije novaRezervacija) 
        {
            using (var context = new PI2227_DBEntities1())
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
        public static bool ProvjeriIspravnostRezervacije(DateTime datum, DateTime pocetak, Adrese odabranaLokacija, Vozila vozilo, bool probnaVoznja)
        {
            if (datum.DayOfYear <= DateTime.Now.DayOfYear)
            {
                MessageBox.Show("Datum na koji želite rezervirati termin mora biti barem sutrašnji datum!");
                return false;
            }
            else
            {
                List<Rezervacije> zaOdabraniDatum;
                if (probnaVoznja)
                {
                    zaOdabraniDatum = DohvatiRezervacije(datum, odabranaLokacija, vozilo);
                }
                else
                {
                    zaOdabraniDatum = DohvatiRezervacije(datum, odabranaLokacija, null);
                }
                foreach (Rezervacije rezervacija in zaOdabraniDatum)
                {
                    if (DateTime.Compare(rezervacija.PocetakRezervacije, pocetak) == 0)
                    {
                        MessageBox.Show("Taj termin je već zauzet!");
                        return false;
                    }
                }
                return true;
            }
        }
        public static List<Adrese> DohvatiLokacijeServisa(string naziv = "")
        {
            List<Adrese> adrese = new List<Adrese>();
            List<Adresa> adreseIzBaze = new List<Adresa>();
            using (var context = new PI2227_DBEntities1())
            {
                var query = from a in context.Adresas
                            where a.OpisPodruznice == "Servis"
                            select a;
                adreseIzBaze = query.ToList();
                foreach (Adresa adresa in adreseIzBaze)
                {
                    if (naziv == "")
                    {
                        adrese.Add(NovaAdresa(adresa));
                    }
                    else
                    {
                        if (adresa.NazivPodruznice.ToLower().Contains(naziv))
                        {
                            adrese.Add(NovaAdresa(adresa));
                        }
                    }
                }
                return adrese;
            }
            
        }
        private static Adrese NovaAdresa(Adresa adresa)
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
            return nova;
        }
    }
}

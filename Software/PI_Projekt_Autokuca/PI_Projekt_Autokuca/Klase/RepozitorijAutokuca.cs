using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_Projekt_Autokuca.Baza;
using AdreseLib;
using SkladisteLib;
using PI_Projekt_Autokuca.Iznimke;

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
            using (var context = new PI2227_DBEntitiesAutokuca())
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
            using (var context = new PI2227_DBEntitiesAutokuca())
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
            using (var context = new PI2227_DBEntitiesAutokuca())
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
            using (var context = new PI2227_DBEntitiesAutokuca())
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
            List<string> predmeti = new List<string>
            {
                "Redovan servis",
                "Dodatna oprema",
                "Popravak limarije",
                "Vjetrobransko staklo",
                "Ostalo"
            };
            return predmeti;
        }
        public static List<Adrese> DohvatiLokacije(bool probnaVoznja)
        {
            List<Adrese> lokacije = new List<Adrese>();
            using (var context = new PI2227_DBEntitiesAutokuca())
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
            using (var context = new PI2227_DBEntitiesAutokuca())
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

            using (var context = new PI2227_DBEntitiesAutokuca())
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
            using (var context = new PI2227_DBEntitiesAutokuca())
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
            using (var context = new PI2227_DBEntitiesAutokuca())
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
        public static void KreirajLokaciju(Adrese nova)
        {
            using (var context = new PI2227_DBEntitiesAutokuca())
            {
                Adresa adresa = new Adresa()
                {
                    Broj = nova.Broj,
                    Mjesto = nova.Mjesto,
                    NazivPodruznice = nova.NazivPodruznice,
                    OpisPodruznice = nova.OpisPodruznice,
                    PostanskiBroj = nova.PostanskiBroj,
                    RadnoVrijemeDo = nova.RadnoVrijemeDo,
                    RadnoVrijemeOd = nova.RadnoVrijemeOd,
                    Ulica = nova.Ulica
                };
                context.Adresas.Add(adresa);
                context.SaveChanges();
            }
        }
        public static void AzurirajLokaciju(int sifra, string broj, string mjesto, string naziv, string opis, string postanskiBroj, TimeSpan rvrijemeOd, TimeSpan rvrijemeDo, string ulica)
        {
            using (var context = new PI2227_DBEntitiesAutokuca())
            {
                var query = from a in context.Adresas
                            where a.IdAdrese == sifra
                            select a;
                Adresa trazena = query.First();
                trazena.Broj = broj;
                trazena.Mjesto = mjesto;
                trazena.NazivPodruznice = naziv;
                trazena.OpisPodruznice = opis;
                trazena.PostanskiBroj = postanskiBroj;
                trazena.RadnoVrijemeDo = rvrijemeDo;
                trazena.RadnoVrijemeOd = rvrijemeOd;
                trazena.Ulica = ulica;
                context.SaveChanges();
            }
        }
        public static void ObrisiLokaciju(Adrese odabrana)
        {
            using (var context = new PI2227_DBEntitiesAutokuca())
            {
                var query = from a in context.Adresas
                            where a.IdAdrese == odabrana.IDAdrese
                            select a;
                Adresa trazena = query.First();
                context.Adresas.Remove(trazena);
                context.SaveChanges();
            }
        }
        public static List<Gume> DohvatiGume(Korisnici prijavljeniKorisnik = null, string pretraga ="")
        {
            List<Gume> gume = new List<Gume>();
            List<Guma> gumas = new List<Guma>();
            using (var context = new PI2227_DBEntitiesAutokuca())
            {
                if (prijavljeniKorisnik == null)
                {
                    var query = from g in context.Gumas
                                select g;
                    gumas = query.ToList();
                }
                else
                {
                    var query = from g in context.Gumas
                                where g.Korisnik == prijavljeniKorisnik.IDKorisnik
                                select g;
                    gumas = query.ToList();
                }
                foreach (Guma guma in gumas)
                {
                    if (pretraga == "")
                    {
                        Gume nova = new Gume()
                        {
                            IDGume = guma.IdGume,
                            KolicinaNaSkladistu = guma.KolicinaNaSkladistu,
                            Proizvodac = DohvatiProizvodaca(guma.Proizvodac),
                            Promjer = guma.Promjer,
                            SifraGume = guma.SifraGume,
                            Sirina = guma.Sirina,
                            Visina = guma.Visina,
                            Vlasnik = PronadiVlasnika(guma.Korisnik),
                            NabavnaCijena = guma.NabavnaCijena,
                            ProdajnaCijena = guma.ProdajnaCijena
                        };
                        gume.Add(nova);
                    }
                    else
                    {
                        if (guma.SifraGume.ToString().Contains(pretraga))
                        {
                            Gume nova = new Gume()
                            {
                                IDGume = guma.IdGume,
                                KolicinaNaSkladistu = guma.KolicinaNaSkladistu,
                                Proizvodac = DohvatiProizvodaca(guma.Proizvodac),
                                Promjer = guma.Promjer,
                                SifraGume = guma.SifraGume,
                                Sirina = guma.Sirina,
                                Visina = guma.Visina,
                                Vlasnik = PronadiVlasnika(guma.Korisnik),
                                NabavnaCijena = guma.NabavnaCijena,
                                ProdajnaCijena = guma.ProdajnaCijena
                            };
                            gume.Add(nova);
                        }
                    }
                }
                return gume;
            }
        }
        public static Vlasnik PronadiVlasnika(int? sifra)
        {
            Vlasnik vlasnik = new Vlasnik();
            using (var context = new PI2227_DBEntitiesAutokuca())
            {
                var query = from v in context.Korisniks
                            where v.IdKorisnika == sifra
                            select v;
                Korisnik korisnik = query.FirstOrDefault();
                if (korisnik != null)
                {
                    vlasnik.IdVlasnika = korisnik.IdKorisnika;
                    vlasnik.Ime = korisnik.Ime;
                    vlasnik.Prezime = korisnik.Prezime;
                    vlasnik.Broj = korisnik.Adresa1.Broj;
                    vlasnik.Ulica = korisnik.Adresa1.Ulica;
                    return vlasnik;
                }
                else
                {
                    return null;
                }
            }
        }
        public static List<AutomobilskiDijelovi> DohvatiDijelove(string pretraga = "")
        {
            List<AutomobilskiDijelovi> dijelovi = new List<AutomobilskiDijelovi>();
            List<AutomobilskiDio> dijeloviBaza = new List<AutomobilskiDio>();
            using (var context = new PI2227_DBEntitiesAutokuca())
            {
                var query = from d in context.AutomobilskiDios
                            select d;
                dijeloviBaza = query.ToList();

                foreach (AutomobilskiDio dio in dijeloviBaza)
                {
                    if (pretraga == "")
                    {
                        AutomobilskiDijelovi novi = new AutomobilskiDijelovi()
                        {
                            KolicinaNaSkladistu = dio.KolicinaNaSkladistu,
                            Proizvodac = DohvatiProizvodaca(dio.Proizvodac),
                            NabavnaCijena = dio.NabavnaCijena,
                            Naziv = dio.Naziv,
                            Original = dio.Original,
                            ProdajnaCijena = dio.ProdajnaCijena,
                            SifraDijela = dio.IdDijela
                        };
                        dijelovi.Add(novi);
                    }
                    else
                    {
                        if (dio.Naziv.ToLower().Contains(pretraga.ToLower()))
                        {
                            AutomobilskiDijelovi novi = new AutomobilskiDijelovi()
                            {
                                KolicinaNaSkladistu = dio.KolicinaNaSkladistu,
                                Proizvodac = DohvatiProizvodaca(dio.Proizvodac),
                                NabavnaCijena = dio.NabavnaCijena,
                                Naziv = dio.Naziv,
                                Original = dio.Original,
                                ProdajnaCijena = dio.ProdajnaCijena,
                                SifraDijela = dio.IdDijela
                            };
                            dijelovi.Add(novi);
                        }
                    } 
                }
                return dijelovi;
            }
        }
        public static Proizvodaci DohvatiProizvodaca(int idProizvodaca)
        {
            using (var context = new PI2227_DBEntitiesAutokuca())
            {
                var query = from p in context.Proizvodacs
                            where p.IdProizvodaca == idProizvodaca
                            select p;
                Proizvodac odabrani = query.FirstOrDefault();
                Proizvodaci proizGuma = new Proizvodaci(idProizvodaca, odabrani.Naziv, odabrani.Kontakt);
                return proizGuma;
            }
        }
        public static List<Proizvodaci> DohvatiProizvodace()
        {
            List<Proizvodaci> proizvodaci = new List<Proizvodaci>();
            List<Proizvodac> proizvodaciBaza = new List<Proizvodac>();
            using (var context = new PI2227_DBEntitiesAutokuca())
            {
                proizvodaciBaza = context.Proizvodacs.ToList();
                foreach (Proizvodac proizvodac in proizvodaciBaza)
                {
                    Proizvodaci novi = new Proizvodaci(proizvodac.IdProizvodaca, proizvodac.Naziv, proizvodac.Kontakt);
                    proizvodaci.Add(novi);
                }
                return proizvodaci;
            }
        }
        public static void KreirajAutomobilskiDio(AutomobilskiDijelovi novi)
        {
            using (var context = new PI2227_DBEntitiesAutokuca())
            {
                AutomobilskiDio provjera = null;
                var query = from a in context.AutomobilskiDios
                            where a.IdDijela == novi.SifraDijela
                            select a;
                provjera = query.FirstOrDefault();
                if (provjera != null)
                {
                    throw new IDAlreadyExists("Automobilski dio s navedenom šifrom već postoji u bazi podataka! Odaberite drugu šifru ili ažurirajte postojeći automobilski dio!");
                }
                else
                {
                    AutomobilskiDio noviBaza = new AutomobilskiDio()
                    {
                        IdDijela = novi.SifraDijela,
                        KolicinaNaSkladistu = novi.KolicinaNaSkladistu,
                        NabavnaCijena = novi.NabavnaCijena,
                        Naziv = novi.Naziv,
                        Original = novi.Original,
                        ProdajnaCijena = novi.ProdajnaCijena,
                        Proizvodac = novi.Proizvodac.IDProizvodaca
                    };
                    context.AutomobilskiDios.Add(noviBaza);
                    context.SaveChanges();
                }
            }
        }
        public static void AzurirajAutomobilskiDio(AutomobilskiDijelovi odabrani)
        {
            using (var context = new PI2227_DBEntitiesAutokuca())
            {
                var query = from d in context.AutomobilskiDios
                            where d.IdDijela == odabrani.SifraDijela
                            select d;
                AutomobilskiDio trazeni = query.First();
                trazeni.KolicinaNaSkladistu = odabrani.KolicinaNaSkladistu;
                trazeni.NabavnaCijena = odabrani.NabavnaCijena;
                trazeni.ProdajnaCijena = odabrani.ProdajnaCijena;
                trazeni.Naziv = odabrani.Naziv;
                trazeni.Original = odabrani.Original;
                trazeni.Proizvodac = odabrani.Proizvodac.IDProizvodaca;
                context.SaveChanges();
            }
        }
        public static void ObrisiDio(AutomobilskiDijelovi odabrani)
        {
            using (var context = new PI2227_DBEntitiesAutokuca())
            {
                var query = from d in context.AutomobilskiDios
                            where d.IdDijela == odabrani.SifraDijela
                            select d;
                AutomobilskiDio zaObrisati = query.First();
                context.AutomobilskiDios.Remove(zaObrisati);
                context.SaveChanges();
            }
        }
        public static void KreirajGumu(Gume nova)
        {
            using (var context = new PI2227_DBEntitiesAutokuca())
            {
                if (nova.Vlasnik == null)
                {
                    Guma guma = new Guma()
                    {
                        KolicinaNaSkladistu = nova.KolicinaNaSkladistu,
                        Korisnik = null,
                        NabavnaCijena = nova.NabavnaCijena,
                        ProdajnaCijena = nova.ProdajnaCijena,
                        Proizvodac = nova.Proizvodac.IDProizvodaca,
                        Promjer = nova.Promjer,
                        SifraGume = nova.SifraGume,
                        Sirina = nova.Sirina,
                        Visina = nova.Visina
                    };
                    context.Gumas.Add(guma);
                    context.SaveChanges();
                }
                else
                {
                    Guma guma = new Guma()
                    {
                        KolicinaNaSkladistu = nova.KolicinaNaSkladistu,
                        Korisnik = nova.Vlasnik.IdVlasnika,
                        NabavnaCijena = nova.NabavnaCijena,
                        ProdajnaCijena = nova.ProdajnaCijena,
                        Proizvodac = nova.Proizvodac.IDProizvodaca,
                        Promjer = nova.Promjer,
                        SifraGume = nova.SifraGume,
                        Sirina = nova.Sirina,
                        Visina = nova.Visina
                    };
                    context.Gumas.Add(guma);
                    context.SaveChanges();
                }  
            }
        }
        public static void AzurirajGumu(Gume odabrana)
        {
            using (var context = new PI2227_DBEntitiesAutokuca())
            {
                var query = from g in context.Gumas
                            where g.IdGume == odabrana.IDGume
                            select g;
                Guma trazena = query.First();
                trazena.KolicinaNaSkladistu = odabrana.KolicinaNaSkladistu;
                trazena.NabavnaCijena = odabrana.NabavnaCijena;
                trazena.ProdajnaCijena = odabrana.ProdajnaCijena;
                trazena.Korisnik = odabrana.Vlasnik.IdVlasnika;
                trazena.Promjer = odabrana.Promjer;
                trazena.SifraGume = odabrana.SifraGume;
                trazena.Sirina = odabrana.Sirina;
                trazena.Visina = odabrana.Visina;
                trazena.Proizvodac = odabrana.Proizvodac.IDProizvodaca;
                context.SaveChanges();
            }
        }
        public static List<Vlasnik> DohvatiVlasnike()
        {
            List<Vlasnik> korisniciPopis = new List<Vlasnik>();
            using (var context = new PI2227_DBEntitiesAutokuca())
            {
                List<Korisnik> korisnici = context.Korisniks.ToList();
                foreach (Korisnik korisnik in korisnici)
                {
                    Vlasnik vlasnik = new Vlasnik()
                    {
                        IdVlasnika = korisnik.IdKorisnika,
                        Ime = korisnik.Ime,
                        Prezime = korisnik.Prezime,
                        Broj = korisnik.Adresa1.Broj,
                        Ulica = korisnik.Adresa1.Ulica
                    };
                    korisniciPopis.Add(vlasnik);
                }
                return korisniciPopis;
            }
        }
        public static void ObrisiGumu(Gume odabrana)
        {
            using (var context = new PI2227_DBEntitiesAutokuca())
            {
                var query = from g in context.Gumas
                            where g.IdGume == odabrana.IDGume
                            select g;
                Guma zaObrisati = query.First();
                context.Gumas.Remove(zaObrisati);
                context.SaveChanges();
            }
        }
    }
}

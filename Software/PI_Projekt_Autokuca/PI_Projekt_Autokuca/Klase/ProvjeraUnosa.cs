using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Projekt_Autokuca.Klase
{
    public static class ProvjeraUnosa
    {
        public static bool IspravnaKolicina(int kolicina)
        {
            if (kolicina < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool IspravnaCijena(decimal nabavna, decimal prodajna)
        {
            if (nabavna < 0 || prodajna < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool PopunjenaSvaPolja(string kolicina, string nabavna, string prodajna, string naziv, string sifra)
        {
            if (kolicina == "" || naziv == "" || nabavna == "" || prodajna == "" || naziv == "" || sifra == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool ProvjeriPopunjenostPoljaGume(string sifra, string sirina, string visina, string promjer, string kolicina, string nabavna, string prodajna)
        {
            if (sifra == "" || sifra == "" || visina == "" || promjer == "" || kolicina == "" || nabavna == "" || prodajna == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool IspravneDimenzije(int sirina, int visina, int promjer)
        {
            if (sirina > 0 && visina > 0 && promjer > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ProvjeriPopunjenostPoljaAdrese(string broj, string ulica, string mjesto, string postBroj, string naziv, string vrsta, string vrijemeOd, string vrijemeDo)
        {
            if (broj == "" || ulica == "" || mjesto == "" || postBroj == "" || naziv == "" || vrsta == "" || vrijemeOd == "" || vrijemeDo == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

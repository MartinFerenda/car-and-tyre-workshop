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
    }
}

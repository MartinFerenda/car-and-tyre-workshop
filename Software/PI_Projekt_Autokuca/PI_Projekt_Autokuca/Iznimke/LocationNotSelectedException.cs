using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Projekt_Autokuca.Iznimke
{
    public class WantedItemNotSelectedException : ApplicationException
    {
        public string Obavijest { get; set; }
        public WantedItemNotSelectedException(string obavijest)
        {
            Obavijest = obavijest;
        }
    }
}

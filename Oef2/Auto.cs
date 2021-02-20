using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef2
{
    public class Auto:IVoertuig
    {
        public string Kenteken { get; set; }
        public string Merk { get; set; }
        public decimal Prijs { get; set; }
        public Auto(string kenteken, string merk, decimal prijs)
        {
            Kenteken = kenteken;
            Merk = merk;
            Prijs = prijs;
        }
    }
}

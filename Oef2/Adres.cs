using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef2
{
    public class Adres
    {
        public string Stad { get; set; }
        public string Postcode { get; set; }
        public string Huisnummer { get; set; }
        public string Straat { get; set; }
        public Adres(string straat,string huisnummer,string stad, string postcode)
        {
            Stad = stad;
            Postcode = postcode;
            Huisnummer = huisnummer;
            Postcode = postcode;
        }
    }
}

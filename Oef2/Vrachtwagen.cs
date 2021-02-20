using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef2
{
    public class Vrachtwagen : Auto
    {
        public int Vrachtcapaciteit { get; set; }
        public Vrachtwagen(string kenteken, string merk, decimal prijs, int vrachtcapaciteit) : base(kenteken, merk, prijs)
        {
            Vrachtcapaciteit = vrachtcapaciteit;
        }
    }
}

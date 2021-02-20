using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef2
{
    public interface IVoertuig
    {
        string Kenteken { get; set; }
        string Merk { get; set; }
        decimal Prijs { get; set; }
    }
}

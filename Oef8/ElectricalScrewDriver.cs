using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef8
{
    public class ElectricalScrewDriver : ScrewDriver
    {
        public int BatterijNiveau { get; set; }
        public ElectricalScrewDriver(int weight, string name, int batterijNiveau) : base(weight, name)
        {
            BatterijNiveau = batterijNiveau;
        }
    }
}

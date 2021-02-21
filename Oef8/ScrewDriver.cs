using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef8
{
    public class ScrewDriver:Tool
    {
        public ScrewDriver(int weight, string name) : base(weight, name)
        {
        }
        public override void Work()
        {
            Console.WriteLine("Screwdriver is screwing a screw");
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}

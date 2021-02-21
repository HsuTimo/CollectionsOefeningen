using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef8
{
    public class Saw : Tool
    {
        public Saw(int weight, string name) : base(weight, name)
        {
        }
        public override void Work()
        {
            Console.WriteLine("Saw is sawing");
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}

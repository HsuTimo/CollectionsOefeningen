using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef8
{
    public class Hammer:Tool
    {
        public bool IsTwoHanded { get; set; }
        public Hammer(int weight, string name, bool isTwoHanded) : base(weight, name)
        {
            IsTwoHanded = isTwoHanded;
        }
        public override void Work()
        {
            Console.WriteLine("Hammer is hammering");
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}

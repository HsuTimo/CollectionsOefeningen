using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef8
{
    public abstract class Tool
    {
        public int Weight { get; set; }
        public string Name { get; set; }
        public Tool(int weight, string name)
        {
            Weight = weight;
            Name = name;
        }
        public abstract void Work();
    }
}

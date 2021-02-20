using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> humans = new List<Human>
            {
                new Man("Jan","Marek",DateTime.Parse("5/1/1954")),
                new Woman("Jessica","New",DateTime.Parse("20/10/1985")),
                new Man("Josef","New",DateTime.Parse("18/5/1991")),
                new Woman("Lucy","New",DateTime.Parse("1/1/2001")),
                new Man("Michael","Futile",DateTime.Parse("21/8/1978")),
                new Man("Simon","Young",DateTime.Parse("8/8/1945")),
                new Man("Thomas","New",DateTime.Parse("5/7/1964")),
            };
            humans.Sort();
            humans.ForEach(Console.WriteLine);
            Human child = humans[6] + humans[3];
        }
    }
}

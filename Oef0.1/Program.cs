using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef0._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 50;
            int max = 150;
            for (int i = min; i < max+1; i++)
            {
                if (i%10==0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("---------------------------------");
            for (int i = min; i < max + 1; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

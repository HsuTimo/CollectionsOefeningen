using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef4
{
    class Program
    {
        static void Main(string[] args)
        {
            ListManipulator listManipulator = new ListManipulator();
            listManipulator.Add(15);
            listManipulator.Add(20);
            listManipulator.Add(59);
            listManipulator.Add(1);
            listManipulator.Add(350);
            listManipulator.Add(41);
            listManipulator.Add(18);
            listManipulator.Add(47);
            listManipulator.Add(28);
            listManipulator.Add(19);
            listManipulator[3] = 75;
            listManipulator.Add(88);
            for (int i = 0; i < listManipulator.Count; i++)
            {
                Console.WriteLine(listManipulator[i]);
            }
        }
    }
}

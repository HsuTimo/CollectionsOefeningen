using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef8
{
    class Program
    {
        static void Main(string[] args)
        {
            ToolBox toolBox = new ToolBox(10000);
            toolBox.Add(new ElectricalScrewDriver(200, "Bosch Screwdriver", 100));
            toolBox.Add(new ScrewDriver(200, "Flathead Screwdriver"));
            toolBox.Add(new Hammer(1200, "Big Hammer", true));
            toolBox.Add(new Hammer(1500, "Sledgehammer", true));
            toolBox.Add(new Saw(300, "Hand saw"));
            Console.WriteLine("Inside the toolbox:");
            foreach (var item in toolBox)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nMaking the tools work:");
            foreach (var item in toolBox)
            {
                ((Tool)item).Work();
            }
            Console.WriteLine($"\nWeight of the two handed hammers: {toolBox.GetTotalTwoHandedHammerWeight()}");   
        }
    }
}

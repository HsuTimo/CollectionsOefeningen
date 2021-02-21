using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef9
{
    class Program
    {
        static void Main(string[] args)
        {
            CSharpProgrammer programmer = new CSharpProgrammer("Carl","New",25,"Visual Studio");
            Console.WriteLine("\nDo work:");
            programmer.Sleep();
            programmer.Run();
            programmer.Program(10);
            programmer.Program(15);
            programmer.Sleep();
            programmer.Program(10);
        }
    }
}

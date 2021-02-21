using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef9
{
    public class CSharpProgrammer : Human
    {
        public string IDE { get; set; }
        private int _exhaustion { get; set; }
        public CSharpProgrammer(string firstName, string lastName, int age, string ide) : base(firstName, lastName, age)
        {
            IDE = ide;
            Console.WriteLine("Creating a programmer:");
            Console.WriteLine(this);
        }
        public void Run()
        {
            Console.WriteLine($"{FirstName} is running");
        }
        public void Sleep()
        {
            Console.WriteLine($"{FirstName} is sleeping");
            _exhaustion = 0;
        }
        public void Program(int linesOfCode)
        {
            if (linesOfCode>10)
            {
                _exhaustion += (linesOfCode - linesOfCode % 10) * 10;   
            }
            if (_exhaustion<20)
            {
                Console.WriteLine($"{FirstName} is programming");
            }
            else
            {
                Console.WriteLine($"{FirstName} is too tired to program!");
            }
        }
    }
}

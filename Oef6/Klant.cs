using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef6
{
    public class Klant
    {
        public int Number { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Klant(int number, string firstName, string lastName)
        {
            Number = number;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef6
{
    public class Adres
    {
        public string Street { get; private set; }
        public int HouseNumber { get; private set; }
        public int RegistryNumber { get; private set; }
        public string City { get; private set; }
        public string Zip { get; private set; }
        public string Country { get; private set; }
        public Adres(string street, int houseNumber, int registry, string city, string zip, string country)
        {
            Street = street;
            HouseNumber = houseNumber;
            RegistryNumber = registry;
            City = city;
            Zip = zip;
            Country = country;
        }
    }
}

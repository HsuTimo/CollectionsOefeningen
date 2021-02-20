using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef6
{
    public class Order:IOrder
    {
        public int Number { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Street { get; private set; }
        public int HouseNumber { get; private set; }
        public int RegistryNumber { get; private set; }
        public string City { get; private set; }
        public string Zip { get; private set; }
        public string Country { get; private set; }
        public string[] Products { get; private set; }
        public int[] Quantities { get; private set; }
        public double[] Prices { get; private set; }
        public Order(Klant klant, Adres adres, Product[] products )
        {
            Number = klant.Number;
            FirstName = klant.FirstName;
            LastName = klant.LastName;
            Street = adres.Street;
            HouseNumber = adres.HouseNumber;
            RegistryNumber = adres.RegistryNumber;
            City = adres.City;
            Zip = adres.Zip;
            Country = adres.Country;
            Products = new string[products.Length];
            Quantities = new int[products.Length];
            Prices = new double[products.Length];
            for (int i = 0; i < products.Length; i++)
            {
                Products[i] = products[i].ProductName;
                Quantities[i] = products[i].Quantity;
                Prices[i] = products[i].Price;
            }
        }
    }
}

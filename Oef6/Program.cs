using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef6
{
    class Program
    {
        static void Main(string[] args)
        {
            Klant klant = new Klant(1,"Koe","Koeienmans");
            Adres adres = new Adres("Koeienstraat",12,1,"Koeienstad","9999","Koeienland");
            List<Product> products = new List<Product>
            {
                new Product("Hooi",500,123.25),
                new Product("Rapen",320,250.12),
                new Product("Knollen",185,87.84)
            };
            Order order = new Order(klant, adres, products.ToArray());
            Gateway gateway = new Gateway();
            gateway.ProcessOrder(order);
            Console.ReadLine();
        }
    }
}

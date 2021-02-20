using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef6
{
    public class Gateway
    {
        public void ProcessOrder(IOrder order)
        {
            var orderHeader = $"Order no. {order.Number}";
            Console.WriteLine(orderHeader);
            Console.WriteLine(new string('-',orderHeader.Length));
            Console.WriteLine();
            Console.WriteLine("Customer:");
            Console.WriteLine($"Name: {order.FirstName} {order.LastName}");
            Console.WriteLine($"Address: {order.Street} {order.HouseNumber}/{order.RegistryNumber}");
            Console.WriteLine($"         {order.City} {order.Zip}");
            Console.WriteLine($"         {order.Country}");
            Console.WriteLine();

            Console.WriteLine("Products:");
            for (int i = 0; i < order.Products.Length; i++)
            {
                Console.WriteLine($"{order.Products[i]}:");
                Console.WriteLine($"    -Quantity:{order.Quantities[i]}:");
                Console.WriteLine($"    -Price:{order.Prices[i]}");
            }
            Console.WriteLine();
            Console.WriteLine(new string('=', orderHeader.Length * 2));
            Console.WriteLine($"Total price: {order.Prices.Sum()}");
        }
    }
}

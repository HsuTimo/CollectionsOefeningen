using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef6
{
    public class Product
    {
        public string ProductName { get; private set; }
        public int Quantity { get; private set; }
        public double Price { get; private set; }
        public Product(string productName, int quantity, double price)
        {
            ProductName = productName;
            Quantity = quantity;
            Price = price;
        }
    }
}

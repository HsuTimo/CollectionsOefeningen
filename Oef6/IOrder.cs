using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef6
{
    public interface IOrder
    {
        int Number { get; }
        string FirstName { get; }
        string Last { get; }
        string Street { get; }
        int HouseNumber { get; }
        int RegistryNumber { get; }
        string City { get; }
    }
}

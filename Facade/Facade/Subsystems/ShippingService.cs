using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Subsystems;

public class ShippingService
{
    public void ShipOrder(string order)
    {
        Console.WriteLine("Shipping order...");
    }
}

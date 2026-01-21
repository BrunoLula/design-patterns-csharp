using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Subsystems;

public class InventoryService
{
    public bool CheckOrder(string order)
    {
        Console.WriteLine("Checking inventory...");
        return true;
    }
}

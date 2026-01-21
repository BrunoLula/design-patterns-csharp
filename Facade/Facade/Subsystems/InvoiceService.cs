using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Subsystems;

public class InvoiceService
{
    public void GenerateInvoice(string order)
    {
        Console.WriteLine("Generating invoice...");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Subsystems;

public class PaymentService
{
    public bool ProcessPayment(string order, decimal paymentDetails)
    {
        Console.WriteLine("Processing payment...");
        return true;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adaptees
{
    public class ExternalPaymentGateway
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount} through External Payment Gateway.");
        }
    }
}

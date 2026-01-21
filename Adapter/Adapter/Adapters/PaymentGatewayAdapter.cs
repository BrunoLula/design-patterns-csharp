using Adapter.Adaptees;
using Adapter.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adapters;

public class PaymentGatewayAdapter : IPaymentService
{
    private readonly ExternalPaymentGateway _externalPaymentGateway;
    public PaymentGatewayAdapter(ExternalPaymentGateway externalPaymentGateway)
    {
        _externalPaymentGateway = externalPaymentGateway;
    }
    public void PayProcess(decimal amount)
    {
        _externalPaymentGateway.MakePayment(amount);
    }

}

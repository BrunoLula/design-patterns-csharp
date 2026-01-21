using Adapter.Adapters;
using Adapter.Adaptees;
using Adapter.Target;

class Program
{
    static void Main()
    {
        IPaymentService paymentService =
            new PaymentGatewayAdapter(new ExternalPaymentGateway());

        paymentService.PayProcess(150.75m);
    }
}
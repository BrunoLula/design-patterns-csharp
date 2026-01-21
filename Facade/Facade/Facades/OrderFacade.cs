using Facade.Subsystems;

namespace Facade.Facades
{
    public class OrderFacade
    {
        private readonly InventoryService _inventory;
        private readonly PaymentService _payment;
        private readonly InvoiceService _invoice;
        private readonly ShippingService _shipping;

        public OrderFacade()
        {
            _inventory = new InventoryService();
            _payment = new PaymentService();
            _invoice = new InvoiceService();
            _shipping = new ShippingService();
        }

        public void ProcessOrder(string productId, decimal amount)
        {
            if (!_inventory.CheckOrder(productId))
                throw new Exception("Product out of stock");

            _payment.ProcessPayment( productId,  amount);
            _invoice.GenerateInvoice(productId);
            _shipping.ShipOrder(productId);
        }
    }
}

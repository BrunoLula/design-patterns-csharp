

namespace Strategy.Context;

public class PickupShippingStrategy : IShippingStrategy
{
    public decimal CalculateShippingCost(decimal orderAmount)
    {
        return 0m;
    }
    public void ShipOrder(string orderId)
    {
        Console.WriteLine($"Pedido {orderId} pronto para retirada na loja.");
    }
}

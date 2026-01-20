

namespace Strategy.Context;

public class CarrierShippingStrategy : IShippingStrategy
{
    public decimal CalculateShippingCost(decimal orderAmount)
    {
        
        return orderAmount * 0.10m;
    }

    public void ShipOrder(string orderId)
    {
        Console.WriteLine($"Pedido {orderId} enviado via Transportadora.");
    }

}


namespace Strategy.Context;

public class CorreiosShippingStrategy : IShippingStrategy
{
    public decimal CalculateShippingCost(decimal orderAmount)
    {
        
        return orderAmount * 0.12m;
    }
    public void ShipOrder(string orderId)
    {
        Console.WriteLine($"Pedido {orderId} enviado via Correios.");
    }
}

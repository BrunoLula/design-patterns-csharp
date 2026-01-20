

using Strategy.Context;

namespace Strategy.Models;

public class ShippingCalculator
{
    private IShippingStrategy _strategy;
    public ShippingCalculator(IShippingStrategy shippingStrategy)
    {
        _strategy = shippingStrategy;
    }
    public decimal CalculateShippingCost(decimal orderAmount)
    {
        return _strategy.CalculateShippingCost(orderAmount);
    }
    public void SetStrategy(IShippingStrategy strategy)
    {
        _strategy = strategy;
    }
    public void ShipOrder(string orderId)
    {
        _strategy.ShipOrder(orderId);
    }
}

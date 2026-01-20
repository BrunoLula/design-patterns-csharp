using Strategy.Context;
using Strategy.Models;
using Strategy.Strategies;

class Program
{
    static void Main()
    {
        var order = new Order( "44345", 200 );

        var calculator = new ShippingCalculator(new CorreiosShippingStrategy());
        Console.WriteLine($"Correios: {calculator.CalculateShippingCost(order.Amount)}");
        calculator.ShipOrder(order.Id);

        calculator.SetStrategy(new CarrierShippingStrategy());
        Console.WriteLine($"Carrier: {calculator.CalculateShippingCost(order.Amount)}");
        calculator.ShipOrder(order.Id);

        calculator.SetStrategy(new PickupShippingStrategy());
        Console.WriteLine($"Pickup: {calculator.CalculateShippingCost(order.Amount)}");
        calculator.ShipOrder(order.Id);
    }
}

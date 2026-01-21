using Decorator.Components;
using Decorator.Decorators;

class Program
{
    static void Main()
    {
        ICoffee coffee = new SimpleCoffee();
        coffee = new MilkDecorator(coffee);
        coffee = new ChocolateDecorator(coffee);
        coffee = new CinnamonDecorator(coffee);

        Console.WriteLine(coffee.GetDescription());
        Console.WriteLine($"Total: ${coffee.GetCost()}");
    }
}

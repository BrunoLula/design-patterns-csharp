using Facade.Facades;

class Program
{
    static void Main()
    {
        var orderFacade = new OrderFacade();
        orderFacade.ProcessOrder("PROD-1", 299.99m);
    }
}

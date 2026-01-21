
using Observer.Models;
using Observer.Observers;
namespace Observer.Subjects;

public class Order : ISubject
{
    private readonly List<IObserver> _observers = new();
    public OrderStatus Status { get; private set; }
    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }
    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }
    public void UpdateStatus(OrderStatus status)
    {
        Status = status;
        Notify();
    }
    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(Status);
        }
    }
    public void CreateOrder(string orderDetails)
    {
        Console.WriteLine($"Order Created: {orderDetails}");
        Notify();
    }
}

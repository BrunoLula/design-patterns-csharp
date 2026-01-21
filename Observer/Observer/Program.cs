using Observer.Observers;
using Observer.Subjects;
using Observer.Models;

class Program
{
    static void Main()
    {
        var order = new Order();

        order.Attach(new EmailObserver());
        order.Attach(new LogObserver());
        order.Attach(new DashboardObserver());

        order.UpdateStatus(OrderStatus.Paid);
        order.UpdateStatus(OrderStatus. Shipped);
    }
}

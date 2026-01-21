using Observer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observers;

public class DashboardObserver : IObserver
{
    public void Update(OrderStatus status)
    {
        Console.WriteLine($"Dashboard Observer: {status}");
    }
}

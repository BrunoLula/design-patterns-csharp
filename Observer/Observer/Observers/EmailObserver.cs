using Observer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observers;

public class EmailObserver : IObserver
{
    public void Update(OrderStatus status)
    {
        Console.WriteLine($"Email Observer: {status}");
    }
}

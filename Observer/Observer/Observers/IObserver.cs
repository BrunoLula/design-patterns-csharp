using Observer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observers
{
    public interface IObserver
    {

        void Update(OrderStatus status);
    }
}

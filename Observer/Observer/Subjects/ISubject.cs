
using Observer.Models;
using Observer.Observers;

namespace Observer.Subjects; 

public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void UpdateStatus(OrderStatus status);
    void Notify();
}

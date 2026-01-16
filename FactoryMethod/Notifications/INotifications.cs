using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Notifications;

public interface INotifications
{

    string typeNotification { get; }

    void sendNotification(string message);
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Notifications;

public class WhatsAppNotification: INotifications
{
    public string typeNotification { get { return "WhatsApp"; } }
    public void sendNotification(string message)
    {
        Console.WriteLine($"Sending {this.typeNotification} Notification with message: {message}");
    }
}

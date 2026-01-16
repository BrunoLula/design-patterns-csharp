using FactoryMethod.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory;

public class NotificationFactory
{

    public static INotifications CreateNotification(NotificationType type)
    {
        switch (type)
        {
            case NotificationType.Email:
                return new EmailNotification();
            case NotificationType.SMS:
                return new SmsNotification();
            case NotificationType.WhatsApp:
                return new WhatsAppNotification();
            default:
                throw new ArgumentException("Invalid notification type");
        }
    }
}

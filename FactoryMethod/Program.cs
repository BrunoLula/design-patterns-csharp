using FactoryMethod;
using FactoryMethod.Factory;

class Program
{
    static void Main()
    {
        var notification = NotificationFactory.CreateNotification(NotificationType.Email);
        notification.sendNotification("Your order has been shipped!");

        notification = NotificationFactory.CreateNotification(NotificationType.SMS);
        notification.sendNotification("Your code is 1234");

        notification = NotificationFactory.CreateNotification(NotificationType.WhatsApp);
        notification.sendNotification("New message received");
    }
}

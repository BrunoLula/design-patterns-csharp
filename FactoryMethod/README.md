Factory Method – Notification Factory
📌 Description

This project demonstrates the Factory Method Design Pattern in C#, using a notification system as the example.

The pattern encapsulates the object creation logic, allowing the client to create objects without knowing their concrete implementations.

🎯 Problem

In many applications, the system needs to send notifications through different channels such as:

Email

SMS

WhatsApp notifications

Instantiating these classes directly using new causes:

Tight coupling between client and concrete implementations

Violation of the Open/Closed Principle

Difficulties when adding new notification types

✅ Solution

The Factory Method Pattern centralizes the creation logic in a factory, allowing the client to request objects through a common interface.

The client interacts only with the INotification interface, while the factory decides which concrete implementation to instantiate.

🧱 Project Structure
02-FactoryMethod/
├── Notifications/
│   ├── INotifications.cs
│   ├── EmailNotification.cs
│   ├── SmsNotification.cs
│   └── WhatsAppNotification.cs
├── Factory/
│   └── NotificationFactory.cs
├── NotificationType.cs
├── Program.cs
└── README.md

🧠 Implementation Details
Key components:

INotification: Common interface for all notifications

Concrete implementations (EmailNotification, SmsNotification, WhatsAppNotification)

NotificationFactory: Responsible for creating notification instances

NotificationType: Enum that defines the available notification types

Simple Factory vs Factory Method

This project uses a Simple Factory approach for simplicity and clarity.

In the classic Factory Method Pattern, object creation is usually delegated to subclasses through virtual or abstract methods.

This distinction is intentional and serves educational purposes.

⚠️ When to Use Factory Method

✔ When object creation logic is complex
✔ When you want to decouple client code from concrete implementations
✔ When new types need to be added without modifying client code

❌ When to Avoid Factory Method

When there is only one concrete implementation

When object creation is trivial and unlikely to change

🏁 Conclusion

This project demonstrates how the Factory Method Pattern improves code flexibility and maintainability by encapsulating object creation logic.

It provides a clean and extensible approach to managing multiple implementations of the same abstraction.

📚 References

GoF – Design Patterns

Refactoring Guru – Factory Method

Clean Architecture – Robert C. Martin

Observer – Order Status Notification System
📌 Description

This project demonstrates the Observer Design Pattern in C#, using an order status notification system as an example.

The pattern defines a one-to-many relationship between objects, so that when one object changes its state, all registered observers are notified automatically.

🎯 Problem

In many systems, when an entity changes state, multiple actions must occur, such as:

Sending emails

Writing logs

Updating dashboards

Implementing this logic directly inside the entity leads to:

Tight coupling

Violation of the Single Responsibility Principle

Difficulties when adding or removing behaviors

✅ Solution

The Observer Pattern solves this problem by:

Separating the core business logic from side effects

Allowing observers to subscribe and unsubscribe dynamically

Notifying all observers automatically when the subject changes state

The subject does not know the concrete implementations of its observers.

🧱 Project Structure
05-Observer/
├── Observers/
│   ├── IObserver.cs
│   ├── EmailObserver.cs
│   ├── LogObserver.cs
│   └── DashboardObserver.cs
├── Subjects/
│   ├── ISubject.cs
│   └── Order.cs
├── Models/
│   └── OrderStatus.cs
├── Program.cs
└── README.md

🧠 Implementation Details
Key components:

Subject: Order

Observer Interface: IObserver

Concrete Observers: Email, Log, and Dashboard

State Model: OrderStatus enum

Observer and SOLID Principles

Single Responsibility: The subject focuses only on its core logic

Open/Closed: New observers can be added without modifying the subject

Dependency Inversion: High-level modules depend on abstractions

🏁 Conclusion

This project demonstrates how the Observer Pattern enables a clean, extensible, and decoupled design for reacting to state changes.

It is especially useful in systems that rely on events, notifications, or domain-driven behavior.

📚 References

GoF – Design Patterns

Refactoring Guru – Observer

Clean Architecture – Robert C. Martin

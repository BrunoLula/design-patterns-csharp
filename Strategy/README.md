Strategy – Shipping Cost Calculator
📌 Description

This project demonstrates the Strategy Design Pattern in C#, using a shipping cost calculation system as an example.

The pattern defines a family of algorithms, encapsulates each one, and allows them to be interchanged at runtime without modifying the client code.

🎯 Problem

In many applications, shipping cost calculation depends on multiple factors and providers, such as:

Postal service

Private carriers

In-store pickup

Implementing this logic with conditional statements (if/else or switch) leads to:

Hard-to-maintain code

Violation of the Open/Closed Principle

Difficulties in testing and extending the logic

✅ Solution

The Strategy Pattern solves this problem by:

Defining a common interface for all algorithms

Encapsulating each algorithm in its own class

Allowing the algorithm to be selected and changed at runtime

The client works with an abstraction instead of concrete implementations.

🧱 Project Structure
04-Strategy/
├── Strategies/
│   ├── IShippingStrategy.cs
│   ├── CorreiosShippingStrategy.cs
│   ├── CarrierShippingStrategy.cs
│   └── PickupShippingStrategy.cs
├── Context/
│   └── ShippingCalculator.cs
├── Models/
│   └── Order.cs
├── Program.cs
└── README.md

🧠 Implementation Details
Key components:

Strategy Interface: IShippingStrategy

Concrete Strategies: Different shipping calculation algorithms

Context: ShippingCalculator, which uses a strategy

Model: Order, containing order data used by strategies

var calculator = new ShippingCalculator(new CorreiosShippingStrategy());

🧩 Strategy and SOLID Principles

Single Responsibility: Each strategy has one responsibility

Open/Closed: New strategies can be added without modifying existing code

Dependency Inversion: High-level modules depend on abstractions

🏁 Conclusion

This project shows how the Strategy Pattern improves flexibility, maintainability, and testability by separating algorithms from the context in which they are used.

It is especially useful in systems where behavior must vary dynamically.

📚 References

GoF – Design Patterns

Refactoring Guru – Strategy

Clean Code – Robert C. Martin

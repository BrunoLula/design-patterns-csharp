Decorator – Coffee Ordering System
📌 Description

This project demonstrates the Decorator Design Pattern in C#, using a coffee ordering system as an example.

The pattern allows additional responsibilities to be added dynamically to an object without modifying its structure or creating a large number of subclasses.

🎯 Problem

In systems where objects can have multiple optional features or behaviors, using inheritance can lead to:

Class explosion

Rigid designs

Difficult maintenance

For example, creating a subclass for every possible coffee combination quickly becomes unmanageable.

✅ Solution

The Decorator Pattern solves this problem by:

Wrapping objects with decorator classes

Adding new behavior dynamically

Preserving the original interface

Each decorator adds its own responsibility while delegating core behavior to the wrapped object.

🧱 Project Structure
06-Decorator/
├── Components/
│   ├── ICoffee.cs
│   └── SimpleCoffee.cs
├── Decorators/
│   ├── CoffeeDecorator.cs
│   ├── MilkDecorator.cs
│   ├── ChocolateDecorator.cs
│   └── CinnamonDecorator.cs
├── Program.cs
└── README.md

🧠 Implementation Details
Key components:

Component Interface: ICoffee

Concrete Component: SimpleCoffee

Base Decorator: CoffeeDecorator

Concrete Decorators: Milk, Chocolate, Cinnamon

Each decorator implements the same interface and wraps another ICoffee instance.

🧩 Decorator vs Inheritance

Inheritance adds behavior at compile time

Decorator adds behavior at runtime using composition

Decorator promotes flexibility and cleaner designs.

🏁 Conclusion

This project shows how the Decorator Pattern provides a flexible alternative to inheritance by using object composition.

It enables dynamic behavior extension while keeping the system clean, extensible, and maintainable.

📚 References

GoF – Design Patterns

Refactoring Guru – Decorator

Clean Code – Robert C. Martin

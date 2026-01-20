Abstract Factory – Cross-Platform UI Components
📌 Description

This project demonstrates the Abstract Factory Design Pattern in C#, using a cross-platform UI component system as an example.

The pattern provides an interface for creating families of related objects without specifying their concrete implementations, ensuring that the created objects are compatible with each other.

🎯 Problem

Applications that support multiple platforms (e.g. Web and Desktop) often need to create UI components such as:

Buttons

Checkboxes

Creating these components directly leads to:

Tight coupling with platform-specific classes

Risk of mixing incompatible components

Difficulties when adding new platforms

✅ Solution

The Abstract Factory Pattern solves this problem by:

Defining an abstract factory interface for creating related objects

Implementing concrete factories for each platform

Ensuring that all objects created by a factory belong to the same family

The client code interacts only with the abstract factory and product interfaces.

🧱 Project Structure
03-AbstractFactory/
├── UI/
│   ├── Buttons/
│   │   ├── IButton.cs
│   │   ├── WebButton.cs
│   │   └── DesktopButton.cs
│   ├── Checkboxes/
│   │   ├── ICheckbox.cs
│   │   ├── WebCheckbox.cs
│   │   └── DesktopCheckbox.cs
    ├── Factories/
    │   ├── IUIFactory.cs
    │   ├── WebUIFactory.cs
    │   └── DesktopUIFactory.cs
├── Program.cs
└── README.md

🧠 Implementation Details
Key components:

Abstract Products: IButton, ICheckbox

Concrete Products: Web and Desktop implementations

Abstract Factory: IUIFactory

Concrete Factories: WebUIFactory, DesktopUIFactory

IUIFactory factory = new WebUIFactory();


The factory determines which family of objects will be created.

🧩 Abstract Factory vs Factory Method

Factory Method creates a single object

Abstract Factory creates families of related objects

Abstract Factory is often implemented using multiple Factory Methods.

🏁 Conclusion

This project demonstrates how the Abstract Factory Pattern helps maintain consistency and flexibility when working with multiple families of related objects.

It is especially useful in cross-platform and multi-environment applications.

📚 References

GoF – Design Patterns

Refactoring Guru – Abstract Factory

Clean Architecture – Robert C. Martin

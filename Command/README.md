Command – Remote Control System
📌 Description

This project demonstrates the Command Design Pattern in C#, using a remote control system as an example.

The pattern encapsulates a request as an object, allowing the system to parameterize clients with different requests, queue or log operations, and support undo/redo functionality.

🎯 Problem

In systems where actions need to be triggered by different sources (UI, APIs, schedulers), directly calling methods on receivers can lead to:

Tight coupling between the caller and the receiver

Difficulty in extending or reusing commands

Lack of support for undo or action history

✅ Solution

The Command Pattern solves this problem by:

Encapsulating each action as a command object

Decoupling the invoker from the receiver

Allowing commands to be executed, undone, or stored

The invoker knows only the command interface, not the concrete receiver.

🧱 Project Structure
07-Command/
├── Commands/
│   ├── ICommand.cs
│   ├── TurnLightOnCommand.cs
│   └── TurnLightOffCommand.cs
├── Receivers/
│   └── Light.cs
├── Invokers/
│   └── RemoteControl.cs
├── Program.cs
└── README.md

🧠 Implementation Details
Key components:

Command Interface: ICommand

Concrete Commands: Encapsulate requests

Receiver: Light, which performs the actual work

Invoker: RemoteControl, which triggers commands

🧩 Command and SOLID Principles

Single Responsibility: Each command represents one action

Open/Closed: New commands can be added without changing existing code

Dependency Inversion: High-level modules depend on abstractions

🏁 Conclusion

This project demonstrates how the Command Pattern enables flexible, extensible, and decoupled action handling.

It is particularly useful in UI frameworks, task scheduling systems, and systems requiring undo/redo support.

📚 References

GoF – Design Patterns

Refactoring Guru – Command

Clean Architecture – Robert C. Martin

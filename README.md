Singleton – AppSettings
📌 Description

This project demonstrates the implementation of the Singleton Design Pattern in C#, using an AppSettings class to manage global application settings.

The goal is to ensure that only one instance of the class exists during the entire application lifecycle, providing a global and safe access point to configuration data.

🎯 Problem

In real-world applications, it is common to access configuration data such as:

Execution environment (Development, Staging, Production)

Connection string

Feature flags (e.g. cache enabled)

Creating multiple instances of these settings may lead to:

Data inconsistency

Higher memory consumption

Unexpected behavior

✅ Solution

The Singleton Pattern solves this problem by guaranteeing:

A single instance of the class

Controlled initialization

Global access point

In this project, the Singleton is implemented using Lazy<T>, ensuring thread safety and lazy initialization.

🧱 Project Structure
01-Singleton/
├── AppSettings.cs
├── Program.cs
└── README.md

🧠 Implementation Details
Key characteristics of the AppSettings class:

sealed to prevent inheritance

Private constructor

Single instance exposed via a static property

Lazy initialization

Thread-safe by design

public static AppSettings Instance => _instance.Value;

▶️ Usage Example
var settings1 = AppSettings.Instance;
var settings2 = AppSettings.Instance;

Console.WriteLine(ReferenceEquals(settings1, settings2)); // true


The example above confirms that both variables reference the same instance.

🏁 Conclusion

This project demonstrates a correct and safe implementation of the Singleton Design Pattern, following object-oriented best practices in C#.

It serves as a conceptual foundation for comparing the classic pattern with modern Dependency Injection approaches.

📚 References

GoF – Design Patterns

Microsoft Docs – Lazy<T>

Clean Code – Robert C. Martin

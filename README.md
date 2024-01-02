# Basics of C#(.Net)

## Topic Covered
- Data types
- Variables
- Oprators
- If Statements
- Nested If Statements
- Array
- Loops
- Funtions
- Error Handling
- OOP
- Class
- Constructors
- Methods
- Switch Case
- Members
- User Inputs
- Properties

# Learning Order of C# Developer
- Syntax
- Debugging
- OOP 
- Desktop Project Type 
- ASP.NET core
- Data Access (How to get data access in application)
- Dependency Injection (Its built in in ASP.NET but not for others, learn details for others)
- html/css
- Javascript
- Azure/Aws (learn a cloud, it is very important)
- Docker (every developer should know docker)
- SQL (MySQL, MongoDB)
- Git

# OOP in C#
### Class and Object : 
```
- Variables inside the class but outside the object is called "MEMBER VARIABLE" or "INSTANCE VARIABLE"
- Variables inside the object called "LOCAL VARIABLE"
- A class can be created by a developer but can not be used by that same developer
- If a developer use that class to create instances we can call that developer "USER" or "CALLER"
- Class name should be started capital letter (convention). Ex: class Human 
- Method name should be started with a verb (convention). Ex: GetFullName()
- A method in a class should be able to execute only one task not many.
```
### UML diagram for class : 
```
- UML, or Unified Modeling Language, is a standardized visual language used in object-oriented software engineering.
- It provides a standard method for creating blueprints of a system
- Class diagram can be provided to the engineers for creating c# reusable class for further use by other developer.
```
### Value type and Reference Type
```
- Reference Type: Creating an instance object from a class (If we modify main reference it will affect all the varable connected to that reference) 
- Value type: Primitive type variable
```csharp
Person person1 = new Person();
```
```

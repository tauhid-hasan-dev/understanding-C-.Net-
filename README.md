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

<details>
  <summary>Class and Object</summary>

  ## Class and Object:

  - Variables inside the class but outside the object are called "MEMBER VARIABLE" or "INSTANCE VARIABLE"
  - Variables inside the object are called "LOCAL VARIABLE"
  - A class can be created by a developer but cannot be used by that same developer
  - If a developer uses that class to create instances, we can call that developer "USER" or "CALLER"
  - Class name should start with a capital letter (convention). Ex: class Human
  - Method name should start with a verb (convention). Ex: GetFullName()
  - A method in a class should be able to execute only one task, not many.

  ### UML diagram for class:

  - UML, or Unified Modeling Language, is a standardized visual language used in object-oriented software engineering.
  - It provides a standard method for creating blueprints of a system
  - A class diagram can be provided to the engineers for creating C# reusable class for further use by other developers.
</details>

<details>
  <summary>Value type and Reference Type</summary>
  
## Value type and Reference Type
Reference Type:
- Creating an instance object from a class (If we modify main reference it will affect all the variable connected to that reference)
In this example person2 is referenced to the person1 
if the person1 object is modified the person2 will be affected as well

```csharp
Person person1 = new Person();
person1.firstName = "Tauhid";
person1.lastName = "Hasan";

Person person2 = new Person();
person2 = person1;
```
Value type: Primitive type variable
- Even if we changed the value of a later to 200 but the value of b will be still 100. Because it is a value type or primitive type.
```csharp
int a = 100;
int b = a;
a = 200
```
</details>
## Data Hiding (Encapsulation)
- we can hide data by defining "SETTER" and "GETTER".
- Data hiding is not data security.
- We can hide data (define "SETTER" and "GETTER") using both Methods and Properties

### Data hiding (defining "SETTER" and "GETTER") using METHODS:
```csharp
  private int length;

  public void SetLength(int length)
  {
      this.length = length;
  }

  public int GetLength()
  {
      return this.length;
  }
```

### Data hiding(defining "SETTER" and "GETTER") using PROPERTIES:
- Properties starts with a capital letter.
- 'value' is build in 'keyword' for set function.
- we can write conditions inside the setter.
  
```csharp
private int height;

public int Height
{
  get
  {
      return this.height;
  }
  set
  {
      this.height = value;
  }
}
```
2nd Alternative to write a property
```csharp
private int height;

public int Height
{
  get => this.height
  set => this.height = value
}
```
AUTO PROPERTY: 3nd Alternative and the shortcut way to write a property (if there is no condition)
- Most of the time we will use auto property
  
```csharp
public int Width { get; set; }
```
<details>
<summary>Cool Dropdown</summary>




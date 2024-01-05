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

<details>
  <summary>Data Hiding (Encapsulation) </summary>

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
</details>

<details>
  <summary>Data Hiding (Encapsulation) </summary>

## Constructors
- In C#, a constructor is a special method that is automatically called when an object of a class is created
- It is used to initialize the object's state or perform any necessary setup operations
- Constructors have the same name as the class and do not have a return type, not even void
- Creator of the class can use constructor to force the user/caller to get certain data as a parameter.
  
### Constructor Overloading:
- A class can have multiple constructors with different parameter lists (overloading).
- User has multiple option to call the contructor.

In this example, FullNameConstructor has multiple constructor and a USER/CALLER can call the constructor 
either with 3 parameter or 2 parameter.
```csharp
public class FullNameConstructor
{
    public FullNameConstructor(string FirstName, string MiddleName, string LastName)
    {
        this.FirstName = FirstName;
        this.MiddleName = MiddleName;
        this.LastName = LastName;
    }

    public FullNameConstructor(string FirstName, string LastName)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
    }
}
```

### Default Constructor:
- If no constructor is defined in a class, the compiler automatically generates a default constructor.
- The default constructor is often used to initialize the fields or properties of the object with default values.
- This helps ensure that the object is in a valid state immediately after creation.
- 

In this example, FullNameConstructor is a Default constructor explicitly created;

```csharp
public class FullNameConstructor
{
    string firstName = "Tauhid";
    int age = "30";

    public FullNameConstructor()
    {
       // Initialization code goes here
    }
}
```
#### Inheritance of Default Constructor 
- When a class is derived from another class (inherits from a base class), and the base class has a default constructor, the derived class will automatically call the default constructor of the base class.
- This ensures that the base class is properly initialized before the derived class.

```csharp
public class MyBaseClass
{
    string name = "Dhaka"
    // Default constructor
    public MyBaseClass()
    {
        // Initialization code for the base class
    }
}

public class MyDerivedClass : MyBaseClass
{
    // No constructor specified, so the default constructor of base class is implicitly used
}

// Creating an object of the derived class(this "derivedObject" has the default state "name" inherited from its base class)
MyDerivedClass derivedObject = new MyDerivedClass();

```

#### Constructor Chaining
- Constructor chaining is a concept in object-oriented programming where multiple constructors in a class are linked together, allowing one constructor to call another within the same class.
- This allows for code reuse and helps in maintaining a clean and modular code structure.

```csharp
class ConstructorChainClass
{
    // Member variables
    private string firstName { get; set; }
    private string middleName { get; set; }
    private string lastName { get; set; }


    // Third : This will be called third
    public ConstructorChainClass(string firstName, string middleName, string lastName):this(firstName, lastName)
    {
        // we do not need to bind other data here except middleName (because we already bind other data inside the second Constructor)
        this.middleName = middleName;
        Console.WriteLine("Contains 3 argument");
    }

    // Second : This will be called second
    public ConstructorChainClass(string firstName, string lastName):this()
    {
        this.firstName = firstName;
        this.lastName = lastName;
        Console.WriteLine("Contains 2 argument");
    }

    // First : Default constructor will be called first
    public ConstructorChainClass()
    {
        Console.WriteLine("Constructor called, Object created, this a default constructor");
    }

}

```
</details>





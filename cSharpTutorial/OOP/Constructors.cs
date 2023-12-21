using System;

namespace OOP
{
    class Person
    {
        // Member variables
        private string firstName;
        private string lastName;
        private string namazStatus;
        private int age;

        // Default constructor
        public Person()
        {
            Console.WriteLine("Constructor called, Object created");
        }

        // Parameterized constructor with three parameters
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        // Parameterized constructor with four parameters
        public Person(string firstName, string lastName, string namazStatus, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.namazStatus = namazStatus;
            this.age = age;
        }

        // Member method
        public void IntroduceMyself()
        {
            if(age >  0 && age < 10 )
            Console.WriteLine("Hi, I am {0} years old and my name is {1} {2}, I am still baby", age, firstName, lastName);
            else if (age > 10 )
            Console.WriteLine("Hi, I am {0} years old and my name is {1} {2}, I must pray", age, firstName, lastName);
        }


    }
}

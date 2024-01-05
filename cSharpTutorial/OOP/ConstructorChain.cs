using System;

namespace OOP
{
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
}

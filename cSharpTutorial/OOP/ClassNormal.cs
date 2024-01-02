using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTutorial.Class
{
    class Human
    {   
        // member variable (instance variable)
        // if the variable is in the class but outside of the object we can call them "Instance Variable"

        public string firstName;
        public string lastName;

        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I am {0} {1}", firstName, lastName);
        }
    }
}

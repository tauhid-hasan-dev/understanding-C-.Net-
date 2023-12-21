using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTutorial.OOP
{
     class HumansConstructor
    {
        // member variable
        private string firstName;
        private string lastName;
        private string cyecolor;
        private int age;
       

        // constructor (we use the constructor to udpate the state or variable of this class called HumansConstructor)
        // Constructor name should be the same with the Class name. 
        public HumansConstructor(string firstName, string lastName, string eyecolor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;  
            this.cyecolor = eyecolor;
            this.age = age;
        }

        // member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I am {0} {1}", firstName, lastName);
            Console.WriteLine("My eye color is {0}", cyecolor);
            Console.WriteLine("My is age {0}", cyecolor);
        }
    }
}

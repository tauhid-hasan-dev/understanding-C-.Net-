using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTutorial.Class
{
    class Human
    {   
        // member variable
        public string firstName;

        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I am {0}", firstName);
        }
    }
}

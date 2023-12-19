using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTutorial.SwitchCase
{
    class SwitchCaseClass
    {
        public static void SwitchCase() {
            Console.WriteLine("This is switch case");

            string userInput = Console.ReadLine();  

            int.TryParse(userInput, out int age);

            switch (age) 
            {
                case 9:
                    Console.WriteLine("Still one year to pray");
                    break;
                case 10:
                    Console.WriteLine("He needs to start praying");
                    break;
                default:
                    Console.WriteLine("How old are you then");
                    break;
            }
        }
    }
}

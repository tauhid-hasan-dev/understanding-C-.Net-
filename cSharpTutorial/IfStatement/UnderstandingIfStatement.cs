using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTutorial.IfStatement
{
    internal class IfStatementClass
    {
        public static void UnderstandingIfStatement() {


            Console.WriteLine("What is temperature today");

            string temperature =Console.ReadLine();
            int numtemp;
            int number;

            bool UserEnteredNumber = int.TryParse(temperature, out number);

            if (UserEnteredNumber)
            {
                numtemp = number;
            }
            else
            {
                numtemp = 0;
            }

            if (numtemp > 10)
            {
                Console.WriteLine("Do not Take the coat");
            }else if(numtemp < 10 && numtemp != 0)
            {
                Console.WriteLine("You must take the coat");
            }else if (numtemp == 10 )
            {
                Console.WriteLine("Teprature is 10");
            } else if (numtemp == 0)
            {
                Console.WriteLine("Temperature set to 0, Please try again with valid number");
            }
 
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTutorial.Loops
{
    internal class WhileClass
    {
        // this is program where any user can press enter to increase the number by one and if user press any button and enter the program will stop.
        public static void UnderstandingWhile() {
            Console.WriteLine("this is while");
            int counter = 0;
            string name = "";

            while (name == "") 
            {
                Console.WriteLine("please press enter to increase number and anything + enter will shut down the program");
                name = Console.ReadLine();
                counter++;
                Console.WriteLine(counter);
            }

        }  
    }
}

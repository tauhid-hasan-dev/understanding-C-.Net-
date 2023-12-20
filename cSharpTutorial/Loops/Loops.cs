using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTutorial.Loops
{
    internal class LoopsClass
    {
        public static void UnderstandingLoops()
        {
            //---------- There are 4 types of loops ---------------

            // 1- for loop
            // 2- while loop (Check first then run the code)
            // 3- do while loop (do first then check)
            // 4- foreach loop (run through array of list)

            /* 
             
            for( start: value, condition, increment) {
             Code body
            }

            while (condition) {
             does not execute the code if condition does not match
             Code body
            }

            //---------- do while condition runs first(
            do {
              execute the code (at least one time);
              
            }while (condition)

            // runs through an array;
            foreach()

             */

            Console.WriteLine("this is loops");
            Console.Read();
        }
    }
}

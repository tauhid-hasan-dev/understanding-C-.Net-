using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTutorial.Loops
{
    internal class BreakContinueClass
    {
        public static void UnderstandingBreakContinue() {
            for (int couter = 1; couter < 10; couter ++)
            {
                if(couter ==  6)
                {
                    // Console.WriteLine("Sorry I can not go after 5");
                    //break; // Stop the iteration(where condition does not match)
                    Console.WriteLine("I skipped 5");
                    continue; // Skip the iteration(Where the condition match)
                }
                Console.WriteLine(couter);
             
            }
            Console.Read();

        }
    }
}

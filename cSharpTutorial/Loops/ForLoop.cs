using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTutorial.Loops
{
    internal class ForLoopClass
    {
        public static void UnderstandingForLoop()
        {
            for (int couter = 1; couter < 10; couter+=2) 
            {
                Console.WriteLine("this is odd number " + couter);
            }
            Console.Read();
        }
    }
}

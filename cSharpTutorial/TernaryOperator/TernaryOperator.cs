using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTutorial.TernaryOperator
{
    internal class TernaryOperatorClass
    {
        public static void UnderstandingTernaryOperator ()
        {
            Console.WriteLine("working");
            int temprature = -5;
            string stateOfMatter;
            string stateOfMatter1;

            stateOfMatter = temprature < 0 ? "Ice" : "water";


            Console.WriteLine("state of matter is {0}", stateOfMatter);
            int tempratur = 5;
            stateOfMatter1 = tempratur < 0 ? "Ice" : "water";

            Console.WriteLine("state of matter is " + stateOfMatter1);
            Console.Read();

        }

    }
}

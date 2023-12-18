using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTutorial.functions
{
    internal class func1
    {

        public static void Calis()
        {
            // we can run a function inside a function as well
            int calculation = Add(Add(5, 6), Add(5, 7));
            int result = Add(45, 67);
            int resultMultiply = Multiply(45, 67);
            Console.WriteLine(result);
            Console.WriteLine(calculation);
            Console.WriteLine("func1 çalıştı");
            Console.ReadLine();
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }


    }


}

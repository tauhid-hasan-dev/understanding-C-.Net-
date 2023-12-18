// Methods
using System;

namespace cSharpTutorial
{
    class Program 
    {

        static void Main(string[] args)
        {
            // we can run a function inside a function as well
            int calculation = Add(Add(5, 6), Add(5, 7));
            int result = Add(45, 67);
            int resultMultiply = Multiply(45, 67);
            // Console.WriteLine(result);
            // Console.WriteLine(calculation);
            // Console.Read();
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



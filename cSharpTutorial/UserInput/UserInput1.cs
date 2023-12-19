using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTutorial.UserInput
{
    class UserInput1
    {
        public static void UnderstandingUserInputs() 
        {
           // string input = Console.ReadLine();
            Console.WriteLine(Calculate());
            Console.Read();
        }

        public static int Calculate()
        {
            Console.WriteLine("Please enter the first number");
            string input1 = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string input2 = Console.ReadLine();

            int num1 = int.Parse(input1);
            int num2 = int.Parse(input2);   

            int result = num1 + num2;   

            return result;
        }




    }
}

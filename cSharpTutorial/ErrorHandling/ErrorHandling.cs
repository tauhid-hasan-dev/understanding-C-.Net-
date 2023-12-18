using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTutorial.ErrorHandling
{
   class ErrorHandlingClass
    {
        public static void CatchErrors() 
        {
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();
            try
            {
                int userInput = int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception, Please enter a valid number");
                // throw; (we will get the error type when we only write "throw" keyword);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exception: Number was too short or too long for int32 ");
                // throw;
            }
            catch (ArgumentException) // we will see this later with nullable false 
            {
                Console.WriteLine("Argument Exception: The value was empty(null)");
            }
        }
    }
}

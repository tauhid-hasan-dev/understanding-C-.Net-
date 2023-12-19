using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTutorial.Operators;

internal class OperatorIndex
{
    // if the method is not PUBLIC we will not be able to access this method outside of this project.
    public static void UnderstandingOperators() {

        int num2 = 5;
        int num1 = 6;
       

        int num3;

        num3 = -num2;

        Console.WriteLine("num is {0}", num3);
     

        // Increment operators

        int num4 = 5;
        var LastNumber = num4++;

        Console.WriteLine("num is {0}", num4); // 6
        Console.WriteLine("num is {0}", num4++); // 6
        Console.WriteLine("num is {0}", LastNumber); // 5
        Console.WriteLine("num is {0}", ++num4); // 8


        //relational and type operator

        bool islower;
        islower = num1 > num2;

        Console.WriteLine(islower);


        // equality operator 
        bool isEqual;
        isEqual = num1 == num2;
        Console.WriteLine(isEqual);

        
        isEqual = num1 != num2;
        Console.WriteLine(isEqual);


        // Conditional operator (and and or operator)
        bool isSunny = false;
        bool isLowerAndSunny;
        bool isLowerOrSunny;

        // And
        isLowerAndSunny = islower && isSunny;

        // Or 
        isLowerOrSunny = islower || isSunny;


        Console.WriteLine("conditional 'and' operator {0}", isLowerAndSunny);
        Console.WriteLine("conditional 'or' operator {0}", isLowerOrSunny);

        Console.Read();
    }
}

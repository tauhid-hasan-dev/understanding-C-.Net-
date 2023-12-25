using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTutorial.Array
{
    internal class ArrayClass
    {
        public static void UnderstandingArray() {

            //---------------- Declaring an array --------------------

            // SYNTAX: dataType[] arrayName
            // Example: int[]grades

            // --------------- Initializing an array ---------------------

            // SYNTAX: dataType[] arrayName = new dataType[amountOfEntries]
            // Example: int[]grades = new int[5];


            // -----------------Assigning value to an arrary------------------------

            // SYNTAX: arrayName[index] = value;
            // Example: grades[0] = 15;
            // Example: grades [1] = 12;

            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 12;
            grades[2] = 14;
            grades[3] = 16;

            Console.WriteLine("grades at index 0 is : {0}", grades[0]);

            string input = Console.ReadLine();

            grades[0] = int.Parse(input);   

            Console.WriteLine("grades at index 0 is : {0}", grades[0]);

  

            // 2nd way of initializing of an array
            int[] gradesOfMathStudentA = { 20, 13, 17 };

            // third way of initializing of an array
            int[] gradesOfMathStudentB = new int[] { 21, 18, 19 };

            Console.WriteLine("The length is : {0}", gradesOfMathStudentA.Length);
            Console.ReadKey();
        }

    }
}

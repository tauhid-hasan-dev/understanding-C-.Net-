using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTutorial.NestedForLoop
{
    class NestedForLoopClass
    {
           public static int[,] matrix = {
                {13,23},
                {43,53},
                {73,83},
            };

        public static void UnderstandingNestedLoop()
        {
            foreach (int item in matrix)
            {
                Console.Write(item + " ");
                // item = 2; // (we can not assign a value to the iterated item for "for each" loop

            }

            Console.WriteLine(matrix.GetLength(0)); // Prints the length of the first dimension (rows) which is 3
            Console.WriteLine(matrix.GetLength(1)); // Prints the length of the second dimension (columns) which is 2


            //------------> what we can not do with for each loop we can do that in for loop. w
            Console.Write("\n This is our 2d array printed using nested for loop");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // Console.WriteLine($"Row {i + 1}:");

                // Console.WriteLine($"This is my number {i}");

                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " " );
                }
            }
           

        }

    }
}

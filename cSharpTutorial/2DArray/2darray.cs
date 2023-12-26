using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTutorial._2DArray
{
    class Class2DArray
    {
        public static void Understanding2dArray()
        {
            Console.WriteLine("This is understanding 2d array");

            // declare 2d array 
            string[,] matrix;

            // 3d array
            string[,,] threeD;


            //two dimensional array (old way)
            int[,] array2D = new int[,]
            {
                { 1, 2, 3},
                { 6, 7, 8},
                { 9, 10, 11}
            };

            // 0 = targetting row in 0 index which is {1, 2, 3}
            // 2 = targetting the element in 2 index which is 3
            Console.WriteLine("Central value is {0}", array2D[0, 2]);

            // Three dimentional array (old way)
            string[,,] array3D = new string[,,]
            {
                {
                  {"000", "001" },
                  {"010", "011" },
                  {"Hi there ", "What is up" },
                },
                {
                  {"100", "101" },
                  {"110", "111" },
                  {"Another one", "Last Entry" },
                }
            };

            Console.WriteLine("The value is {0}", array3D[1,2,1]);

            // old way
            string[,] array2DString = new string[3, 2] {
                   { "one", "two"},
                   { "three", "four" },
                   {"five", "six" }
                };

            array2DString[2, 1] = "I just changed this";

            Console.WriteLine("The value is ----> {0}", array2DString[2,1]);


            //====================== THERE IS A MODERN VERSION FOR DECLARING AN ARRAY ==============================
            // with out mentioning the right side we can directly declare the array in a modern way

            // modern way
            int[,] array2d2 = { { 1, 2, 3 }, { 6, 7, 8 }, };

            // modern way 
            string[,,] array3d2 =  {
                {
                  {"000", "001" },
                  {"010", "011" },
                  {"Hi there ", "What is up" },
                },
                {
                  {"100", "101" },
                  {"110", "111" },
                  {"Another one", "Last Entry" },
                }
            };



            Console.ReadKey();
            

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTutorial.JaggedArray
{
    internal class JaggedArrayClass
    {
        public static void UnderstandingJaggedArray()
        {
            // Jagged Array simply means, Arrays into an array 

            //-----------------> declare jagged Array <-------------------------------
            // In this example I am creating a jgged array which have two element of array 

            int[][] jaggedArray = new int[2][];

            // declaring the elements of array
            jaggedArray[0] = new int[3]; // I am declaring the first element as an Array of 3 element;
            jaggedArray[1] = new int[2]; // Same here as an array of 2 element;

            // assigning the elements
            jaggedArray[0] = new int[] { 1, 3, 6}; 
            jaggedArray[1] = new int[] { 5,7,8 };


            //-----------------> Alternative way 
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 1, 3, 6},
                new int[] { 7,8,9}
            };


            Console.WriteLine($"The value in the middle of the first entry is {jaggedArray[0][1]}");




        }

    }
}

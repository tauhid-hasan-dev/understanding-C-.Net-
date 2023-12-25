using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTutorial.ForEachLoop
{
    internal class ForEachClass
    {
        public static void UnderstandingForEach()
        {
            // Create an array of integers with a length of 10
            int[] nums = new int[10];

            // Initialize the array with values from 0 to 9 using a for loop
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i + 5;
            }

            // Use a for loop to iterate through the array and print each element
            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("{0} = {1}", j, nums[j]);
            }


            // new Array and iterating with foreach

            int[] numsOne = new int[10];

            for (int i = 0; i < 10; i++)
            {
                numsOne[i] = i + 100;
            }

            // Using a foreach loop to iterate through the array and print each element (doing exactly same things as for loop here)
            int counter = 0;
            foreach(int k in numsOne)
            {
                Console.WriteLine("{0} = {1}", counter, k);
                counter++;
            }


            string[] friends = { "yakup", "ali", "yusuf", "monjur", "rashed"};

            foreach(string s in friends)
            {
                Console.WriteLine("Hello " + s + ", Long time no see");
            }
            

            // Wait for a key press before exiting the program
            Console.ReadKey();
        }
    }
}

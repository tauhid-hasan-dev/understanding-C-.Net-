using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTutorial.ArrayListNameSpace
{
    internal class ArrayListClass

    {
        public static void UnderstandingArrayList() 
        {
            // Declaring the array list with undefined amount of object 
            ArrayList myArrayList = new ArrayList();             
            
            // Declaring the array list with defined amount of object 
            ArrayList myArrayList2 = new ArrayList(100);

            // Array list has different types of method some them are here....


            myArrayList.Add(24); //int
            myArrayList.Add("Hello"); //string
            myArrayList.Add(13.37); // double
            myArrayList.Add(true); // bool
            myArrayList.Add(15); // int
            myArrayList.Add(18.89); // double


            // delete element with specific value from the arraylist
            // myArrayList.Remove(15);

            // delete element at specific position 
            // myArrayList.RemoveAt(0);

            Console.WriteLine(myArrayList.Count);

            double sum = 0;
            foreach (object obj in myArrayList)
            {
                // Console.WriteLine(obj);
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if(obj is double) 
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is string) {
                    Console.WriteLine(obj);
                }
            }



            Console.WriteLine(sum);
            Console.ReadKey();



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTutorial.Loops
{
    internal class DoWhileClass
    {
        public static void UnderstandingDoWhile() 
        {
            Console.WriteLine("This is understading do while loop");

            int lenghOfText = 0;
            string wholeText = "";

            do
            {
                Console.WriteLine("Please enter the name of a friend");
                string nameOfFriend = Console.ReadLine();
                int currentLengh = nameOfFriend.Length;
                lenghOfText += currentLengh;
                wholeText += nameOfFriend;
            }
            while (lenghOfText < 20);
            Console.WriteLine("Thanks, that was enough!" + wholeText);
            Console.Read();
        }
    }
}

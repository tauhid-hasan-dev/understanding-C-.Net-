using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTutorial.NestedIfStatement
{
    class NestedIfStatementClass
    {
        public static void UnderstadingNestedIfStatement() {
            

            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please enter your username");

            userName = Console.ReadLine();

            if (isRegistered && userName != "" && userName.Equals("admin") )
            {
                Console.WriteLine("Hi there, registered user");
                Console.WriteLine("Hi there {0}", userName);
                Console.WriteLine("You are logged in admin");
            }

            if(userName != "admin")
            {
                Console.WriteLine("You are logged in " + userName);
            }
        }
    }
}

// Main Program file
// important note : Only public method can be accessed from other file

using cSharpTutorial.Operators;
using cSharpTutorial.functions;
using cSharpTutorial.UserInput;
using cSharpTutorial.ErrorHandling;

using System;
using System.Runtime.CompilerServices;
using cSharpTutorial.IfStatement;
using cSharpTutorial.NestedIfStatement;
using cSharpTutorial.SwitchCase;
using cSharpTutorial.TernaryOperator;
using cSharpTutorial.Loops;
using cSharpTutorial.Class;
using OOP;
using cSharpTutorial.Properties;
using cSharpTutorial.UnderstandingMembers;


namespace cSharpTutorial
{
    class Program 
    {
        static void Main(string[] args)
        {
            // UserInput1.UnderstandingUserInputs();
            // func1.UnderstandingFunctions();1
            // ErrorHandlingClass.CatchErrors();
            // OperatorIndex.UnderstandingOperators();
            // IfStatementClass.UnderstandingIfStatement();
            // NestedIfStatementClass.UnderstadingNestedIfStatement();
            // SwitchCaseClass.SwitchCase();
            // TernaryOperatorClass.UnderstandingTernaryOperator();
            // LoopsClass.UnderstandingLoops();
            // ForLoopClass.UnderstandingForLoop();
            // DoWhileClass.UnderstandingDoWhile();
            // WhileClass.UnderstandingWhile();
            // BreakContinueClass.UnderstandingBreakContinue();

            //-------------------Normal Class----------------------------

            //---> this is a instance object created from the "Human" class
            //Human tauhid = new Human(); 

            //---> we can only access the member variable if it is public
            //---> but !!! Using constructor we can access private member variable of a class
            //tauhid.firstName = "Tauhid";
            //tauhid.lastName = "Hasan";
            //tauhid.IntroduceMyself();

            //---> this is a another instance object created from the "Human" class
            //Human musa = new Human();
            //musa.firstName = "Ahmad";
            //musa.lastName = "Musa";
            //musa.IntroduceMyself();


            //---------------------------- Single and multiple Constructors --------------------------

            //---> Using the default constructor
            // Person person1 = new Person();

            //---> Using the parameterized constructor with three parameters
            // Person person2 = new Person("Muaz", "Hasan", 8);

            //---> Using the parameterized constructor with four parameters
            // Person person3 = new Person("Tauhid", "Hasan", "Praying", 30);

            //---> Calling the IntroduceMyself method
            // person1.IntroduceMyself();
            // person2.IntroduceMyself();
            // person3.IntroduceMyself();

            //----------------------------------Properties -----------------------------------------------

            // Box box = new Box();
            // box.SetLength(60); //-------> SET: we can not "SET" data if the variable is private
            // Console.WriteLine("The box length is {0}", box.GetLength()); //--------> GET: we can not get data if variable is private

            //box.Height = 89;
            //Console.WriteLine("The box length is {0}", box.Height);
            //box.width = 4;
            //box.length = 12;

            //box.DisplayInfo();

            //----------------------------------Members-------------------------------------


            Members member1 = new Members();
            member1.introducing(true);

            //Console.ReadKey();




        }
    }



}



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
using cSharpTutorial.OOP;

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


            //---------------------------- Constructors --------------------------

            HumansConstructor musa = new HumansConstructor("Mehedi", "Hasan", "blue", 26);
            musa.IntroduceMyself();






        }
    }



}



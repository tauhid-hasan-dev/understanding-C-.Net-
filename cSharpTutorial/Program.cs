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
using cSharpTutorial.Array;
using cSharpTutorial.ForEachLoop;
using cSharpTutorial._2DArray;
using cSharpTutorial.NestedForLoop;
using cSharpTutorial.JaggedArray;
using Microsoft.VisualBasic;
using cSharpTutorial.ArrayListNameSpace;
using Microsoft.Win32.SafeHandles;
using cSharpTutorial.OOP;
using cSharpTutorial.OOP.One_To_Many.cs;
using System.Xml.Serialization;
using cSharpTutorial.NumericDataTypes; // this is namespace of corresponding file.



namespace cSharpTutorial
{
    class Program 
    {
        static void Main(string[] args)
        {
            NumericDataTypesClass.UnderstandingNumericDataTypes();
            
            
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


            // Members member1 = new Members();
            // member1.introducing(true);

            //Console.ReadKey();


            //---------------------------------- Array---------------------------------------

            // ArrayClass.UnderstandingArray();


            //---------------------------------- For Each Loop ---------------------------------------

            // ForEachClass.UnderstandingForEach();


            //----------------------------------- 2D Array ---------------------------

            // Class2DArray.Understanding2dArray();


            // ----------------------- Nested for loop -------------------------------

            // NestedForLoopClass.UnderstandingNestedLoop();


            // ----------------------- Jagged Array ---------------------------

            // JaggedArrayClass.UnderstandingJaggedArray();


            // ---------------------- Array List -------------------------

            // ArrayListClass.UnderstandingArrayList();

            //------------------------ OOP--------------------------------

            //***** Constructor Chain ********

            // ConstructorChainClass person = new ConstructorChainClass("tauhid", "hasan", "tazin");


            //--------------------- Assoisiation Relasionship -----------------------------

            // -------------------- OneTo One Relationship ----------------


            //Address address = new Address();
            //address.RoadNo = "102";
            //address.Area = "Mohakhali";
            //address.PostCode = "56677";

            //Person person1 = new Person();

            //person1.PresentAddress = address;

            //----> Retrieving the myAddress data from person1 instance (of Person class)
            //in here "Address" is type

            // Address myAddress = person1.PresentAddress; 

            //----> If we want we can retrieve only one property from the address

            // string area = person1.PresentAddress.Area;
            // OR
            //string area1 = myAddress.Area;


            //-------------------------- One to many relationship ----------------------

            /*Course course1 = new Course();
            course1.Code = "CSE-101";
            course1.Title = "Web Development";
            course1.Credit = 3.0;

            Course course2 = new Course();
            course2.Code = "CSE-102";
            course2.Title = "Data Structure";
            course2.Credit = 3.0;

            Course course3 = new Course();
            course3.Code = "CSE-103";
            course3.Title = "Database Design";
            course3.Credit = 3.0;

            Department department = new Department();
            department.Code = "CSE";
            department.Name = "Computer Science & Engineering";

            department.Courses.Add(course1);
            department.Courses.Add(course2);
            department.Courses.Add(course3);

            var result =  department.GetInfo();*/
            /*Console.WriteLine(result);*/

            Console.ReadLine();
        }
    }



}



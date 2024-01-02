using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTutorial.UnderstandingMembers
{
    class Members
    {
        // member - variable (public)

        public string memberName;
        public string jobTitle;
        public int salary;

        // member - variable (private)

        public int age;


        // member - properties - exposes jobtitle safety- properties start with a capital letter
        public string JobTitle 
        { set
            {
                this.memberName = value;
            } 
            get 
            { 
                return memberName; 
            }
        
        }

        //----------------- we can write this property to hide data in an alternative way ------------


        //public string JobTitle
        //{
        //    set => this.memberName = value;
        //    get => memberName;
        //}

        // public member method - can be called from other class

        public void introducing (bool isFriend) { 

            if(isFriend){
                SharingPrivateInfo();
            }
            else{
                Console.WriteLine("Hi my name is {0}, my jobtitle is {1}, my age is {2}", memberName, age);
            }
        }

        private void SharingPrivateInfo(){
            Console.WriteLine("My salary is the {0}", salary);
        }

        // member - constructor (contructor name will be same as the class name);
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";

            Console.WriteLine("Object created");
            
        }


        // member - finalizer - destructor 
        // NOTE: we should not create empty finalizer because it slows down the application)

        ~Members() {
            // clean up statement 
            Console.WriteLine("Destruction of member object");
            Debug.Write("Destruction of member object");
        }

    }
}

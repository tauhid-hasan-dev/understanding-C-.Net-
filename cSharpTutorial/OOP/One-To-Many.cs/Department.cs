using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace cSharpTutorial.OOP.One_To_Many.cs
{
    internal class Department
    {
        // This is a property of the Department class, representing a list of Course objects.
        // This indicates a one-to-many association between a department and its courses.
        // A department can have multiple courses.
        public List<Course> Courses { get; set; } // this is a list of Co

        // This is a constructor for the Department class. It initializes the Courses property as a new instance of List<Course>.
        // This ensures that when a Department object is created, it starts with an empty list of courses.
        public Department() 
        { 
            Courses = new List<Course>();
        }

        public string Code { get; set; }
        public string Name { get; set; }

        // getting the department
        public string GetInfo()
        {
            string info = "Code: " + Code + " Name: " + Name + Environment.NewLine;
            foreach (Course course in Courses)
            {
                info += course.getInfo() + "\n";            }
            return info;
        }

    }
}

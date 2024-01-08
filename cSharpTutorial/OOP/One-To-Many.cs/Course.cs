using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cSharpTutorial.OOP.One_To_Many.cs
{
    internal class Course
    {

        public string Code { get; set; }
        public string Title { get; set; }
        public double Credit { get; set; }

        public string getInfo()
        {
            return (Code + " - " + Title + " - " + Credit);
        }
    }
}

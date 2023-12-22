using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTutorial.Properties
{
    class Box
    {
        // member variable 
        public int length;
        private int height;
        public int width;
        public int volume;

        // fIRST: way to define "SETTER" and "GETTER"
        //public void SetLength(int length)
        //{
        //    this.length = length;
        //}

        //public int GetLength()
        //{
        //    return this.length;
        //}

        // SECOND: way to define "SETTER" and "GETTER"

        public int Height 
        {  
            get { return this.height; }
            set { 
                if(value < 0) 
                this.height = -value; 
                else
                this.height = value; 
            }
        }


        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}", length, height, width, volume = length * height * width);  
        }

    }
}

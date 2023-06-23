using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OOPSection_One
{
    internal class Rectangle
    {
        public int Height { get; set; } //initially if no value is set these will be equal to zero
        public int Width { get; set; } //note these are properties the fields are set automaticaly for you if you sue properties like this. 
        //if the fields were private you and no property there would be access modifier constraints 


        public int CalculateCircumference() //if private not able to access from program.cs !! 
        {
            return 2 * Height + 2 * Width;
        }

       public int CalculateArea()
        {
            return Height * Width;
        } 

    }

}

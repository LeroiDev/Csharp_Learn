using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Caleb_PartTwo
{
    internal class Teacher : User
    {

        public Teacher(string sFirstName, string sLastName) : base(sFirstName, sLastName)
        {

        }


        public override void HelloToConsole()
        {
            Console.WriteLine($"Hi, I am a teacher and my name is {FullName}");
        }
    }
}

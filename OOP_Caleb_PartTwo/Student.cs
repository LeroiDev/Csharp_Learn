using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Caleb_PartTwo
{
    internal class Student : User
    {
        //public Student()
        //{
        //    Console.WriteLine("Student Constructor invoked ! ");
        //}
        //This was just to illustrate the call to the default class
        

        public Student(string sName, string sLastName) : base(sName, sLastName)
        {
          //  FirstName = sName; NOTICE with the constuctor in the parent class User how this code has changed and why for READ ONLY PROPERTIES 
          //  LastName = sLastName;
          ////NOTE again you inhereted these so you have access to them !
        } //note you cannot call default constructor anymore if it's not defined here when you have a constructor with parameters ! 

        public override void HelloToConsole()
        {
            Console.WriteLine($"Hi, I am a student and my name is {FirstName.ToUpper()}");
        } // has to be done as this is now an abstact method and Studen class inherits from User class

    }
}

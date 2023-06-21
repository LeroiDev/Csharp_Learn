using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Caleb_PartTwo
{
    internal abstract class User //class being abstract means you cannot create an instance of the User class 
    {
        public User()
        {
            Console.WriteLine("User Class Constructor invoked!");
        } //just to illustrate note if another constructor is called obviously this won't fire this is the default 

        public User(string sName, string sLastName)
        {
            FirstName = sName;
            LastName = sLastName;
        }


        public bool verified { get; set; } = false; //default to false
        public string FirstName { get; } //note again public fields are a no no. 
        public string LastName { get; } //Note this makes a property READ ONLY - you can no longer assisnt to it in your code
        //you can however create a constructor that will allow for you to get an initial value to use as Read Only thereafter. 

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }


        //public virtual void HelloToConsole()
        //{
        //    Console.WriteLine($"Hi my name is {FirstName}");
        //} //Note with virtual the overrride was optional with abstract that is no longer the case it needs to be done for deriving classes from the User class. 


        public abstract void HelloToConsole(); //note with abstract there is no method body

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Caleb
{
    internal class User
    {
        //public string Name; - public field but not good practice
        string _firstName = "Leroi"; //- private field //there is a set property so this can be overwritten this is just a default value

        //create a property 
        //public string FirstName { get; set; } //auto implemented property and will generate a private field for you in the background 
        public string FirstName // this is to have more customization on our fields 
        {
            get
            {
                return _firstName.ToUpper(); // note more customization
            } //read only if just get property 
            set
            {
                _firstName = value; //implicit parameter called value - if we set the value on an instance it will be passed here as the value
            }
        }

        public string FullName { 
            get 
            {
                return FirstName + " " + LastName; 
            } 
        }


        public string LastName { get; set; }
        
        //create a method - notice how public keyword is needed to access it in the other part of the program on the instance of the class 
        public string GreetUser()
        {
            return "Greetings " + FirstName + " " + LastName;
        }

        public string GreetUser(int times)
        {
            string sMsg = "";
            for(int i = 1; i <= times; i++)
            {
                sMsg += $"Hello there {FirstName} {LastName}\n";
            }
            return sMsg;        
        }

        public static void PrintUser(User user)
        {
            Console.WriteLine("Static method executed. . .");
            Console.WriteLine(user.GreetUser(1)); 
        }

        public static int FindFirstName(List<User> users, string fullName)
        {
            for(int i = 0; i < users.Count; i++)
            {
                if(users[i].FullName == fullName)
                    return i;
            }
            return -1;
        }

    }
}

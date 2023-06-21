using OOP_Caleb;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        Program program = new Program();
        //Console.WriteLine(program.DoSomething()); 
        //program.ListsAndUserObjects();
        //program.PopulatingCustomLists();
        //program.StaticMethodOnClassShowcase();
        //program.FindFirstNameUsingStaticMethod();
        program.ReturnCustomObjects();
    }
    
    void ReturnCustomObjects()
    {







    }





    void FindFirstNameUsingStaticMethod()
    {
        User user1 = new User();
        user1.FirstName = "Leroi";
        user1.LastName = "Weitz";

        User user2 = new User();
        user2.FirstName = "John";
        user2.LastName = "Doe";

        User user3 = new User();
        user3.FirstName = "Steve";
        user3.LastName = "Rogers";

        List<User> users = new List<User> { user1, user2, user3};
        int indexInUserList = User.FindFirstName(users, "LEROI Weitz");

        Console.WriteLine($"Found user as: {users[indexInUserList].FullName}"); 
    }



    void StaticMethodOnClassShowcase()
    {
        User user = new User();
        user.FirstName = "Ben";
        user.LastName = "Doe";
        User.PrintUser(user);
    }

    void PopulatingCustomLists()
    {
        List<string> listOfFirstNames = new List<string> { "John","Marry", "Sue","Pepper","Shawn"};
        List<string> listOfLastNames = new List<string> { "Doe", "Poppins", "Storm", "Pots", "Dead" };

        List<User> userList = new List<User>();

        for(int i = 0; i < listOfFirstNames.Count; i++)
        {
            User user = new User();
            user.FirstName = listOfFirstNames[i];
            user.LastName = listOfLastNames[i];
            userList.Add(user);
        }

        foreach (User user in userList)
        {
            Console.WriteLine(user.FullName);
        }
    }

    void ListsAndUserObjects()
    {
        User me = new User();
        me.FirstName = "Leroi";
        me.LastName = "Weitz";

        User anotherUser = new User();
        anotherUser.FirstName = "Pan";
        anotherUser.LastName = "Head";

        List<User> userList = new List<User> { me, anotherUser };

        foreach (User user in userList)
        {
            Console.WriteLine(user.FullName);
        }
    }


    string DoSomething()
    {
        User user = new User();
        user.FirstName = "nameoverwrite"; //Read only if only a get property - therefore if only get can't assign to it / READ ONLY with just GET property 
        user.LastName = "Weitz";
        Console.WriteLine("Public class method used this time: " + user.GreetUser());
        Console.WriteLine(user.GreetUser(5));
        Console.WriteLine("Pint users fullname from the property FullName: " + user.FullName);
        return $"Hello {user.FirstName} {user.LastName}.";
    }
}
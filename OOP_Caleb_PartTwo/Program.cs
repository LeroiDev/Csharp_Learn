using OOP_Caleb_PartTwo;

internal class Program
{
    private static void Main(string[] args)
    {
        Program program = new Program();
        program.InheritanceExamplesStart();

    }

    void InheritanceExamplesStart()
    {
        Student me = new Student("Leroi", "Weitz");
        //me.FirstName = "Leroi";
        //me.LastName = "Weitz";
        //me.verified = true; //Doing this with a custom constructor

        Teacher you = new Teacher("Elon","Musk");
        //you.FirstName = "Elon";
        //you.LastName = "Musk"; 
        //Note moved into using ReadOnly properties hence a construcor is now needed to get the initial value
        //TAKE NOTE these properties are read only on the parent class level therefore you can also not assign them here outside the constructor

        List<User> users = new List<User>() { me, you };

        foreach (User user in users)
        {
            user.HelloToConsole();
        }

        //Console.WriteLine(me.FullName);
        //me.HelloToConsole();

        //User user = new User();//Cannto do this as the class is specified to be abstract !
    } 
}
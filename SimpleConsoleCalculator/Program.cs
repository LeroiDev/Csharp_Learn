internal class Program
{
    private static void Main(string[] args)
    {
        void Addition(int a, int b){
            Console.WriteLine(a + " + " + b + " = " + (a+b));
        }

        void Subtraction(int a, int b)
        {
            Console.WriteLine(a + " - " + b + " = " + (a - b));
        }

        void Multiplication(int a, int b)
        {
            Console.WriteLine(a + " x " + b + " = " + (a * b));
        }

        Console.WriteLine("Hello and Welcome to simple calculator");
        Console.WriteLine("Input the first number: ");

        int iFirstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Input the second number: ");
        int iSecondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("What do you want to do with these numbers ? \n [A]dd\n[S]ubtract\n[M]ultiply");
        string userChoice = Console.ReadLine();

        if (userChoice.ToLower() == "a") {
            Addition(iFirstNumber, iSecondNumber); 
        }
        else if (userChoice.ToLower() == "s")
        {
            Subtraction(iFirstNumber, iSecondNumber);
        }
        else if (userChoice.ToLower() == "m")
        {
            Multiplication(iFirstNumber, iSecondNumber);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }

    }
}
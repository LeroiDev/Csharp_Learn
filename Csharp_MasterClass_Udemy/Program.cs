using System.Net.NetworkInformation;
using System.Xml.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        Program program = new Program();
        //program.FirstPartIntro();
        //SecondPartIntro();
        //program.SomeLoopPractice();
        //program.SomeLoopExercise();
        //program.DoingSomeDoWhileRefresh();
        //program.QuickDoLoopPracticeAgain();
        //program.ForLoopPracticeOverview();
        //program.ForLoopFactoralPractice();
        program.ArrayPractice();





        //for(int i = 1; i < 11; i++)
        //{
        //    if(i == 5 )
        //        continue;
        //    Console.WriteLine(i);
        //}
        //Console.WriteLine("LOOP COMPLETE");


        //void SecondPartIntro()
        //{
        //    int a = 2, b = 3;
        //    string s = $"This is my string and this is {a} and {b} and adding them gives {a + b}";
        //    Console.WriteLine(s);
        //}  

    }

    void ArrayPractice()
    {
        string[] words = { "one", "two", "three", "four", "hello","bye","biosyn" };

        bool IsWordPresentInCollection(string[] words, string wordToBeChecked)
        {
            bool isWordPresent = false;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == wordToBeChecked)
                {
                    return true;
                }
                else
                {
                    isWordPresent = false;
                }
            }
            return isWordPresent;
        }

        Console.WriteLine(IsWordPresentInCollection(words, "biosyn")); 


        //  string BuildHelloString()
        //{
        //    char[] letters = { 'h', 'e', 'l', 'l', 'o' };
        //    var result = "";
        //    for (int i = 0; i < letters.Length; ++i)
        //    {
        //        result += letters[i];
        //    }
        //    return result;
        //}

        //Console.WriteLine(BuildHelloString());

        ////add an array here and add all the elements together to a sum using a for loop 
        //int[] numbers = new int[] { 2, 45, 67, 2, 5, 6, 26, 6, 6 };
        //int sum = 0;
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    sum += numbers[i];
        //}
        //Console.WriteLine($"The total of the elements in the array are: {sum}");
    }


      void ForLoopFactoralPractice()
    {
         int Factorial(int number)
        {
            int total = 1;

            for(int i = 1; i <= number; i++)
            {
                total *= i;
            }
            return total;
        }
        Console.WriteLine(Factorial(5)); 
    }

        void ForLoopPracticeOverview()
    {
        for(int i = 1; i <= 10; i++) //this will count out 1 to 10 - note start point and when to end - understand why
        {
            Console.WriteLine(i);
        } 
    }






    void QuickDoLoopPracticeAgain()
    {

        string RepeatCharacter(char character, int targetLength)
        {
            string sMsg = "";
            do
            {
                sMsg += character;
                targetLength--;
            } while (targetLength > 0);
            
            return sMsg;
        }

        Console.WriteLine(RepeatCharacter('!', 0)); 
    }



    void DoingSomeDoWhileRefresh()
    {
        string sUserInput;

        do
        {
            Console.WriteLine("Enter a message longer than 10 characters to proceed.");
            sUserInput = Console.ReadLine();
        }while (sUserInput.Length <= 10);
    }


    void SomeLoopExercise()
    {
        //        While loop -CalculateSumOfNumbersBetween
        //Using the while loop, implement the CalculateSumOfNumbersBetween method, which given two integers called firstNumber and lastNumber, should calculate the sum of numbers between them(including the numbers themselves).



        //If lastNumber is smaller than firstNumber, the result shall be 0.

        //For example:

        //for firstNumber equal to 5 and lastNumber equal to 10, the result should be 45 because this is the sum of numbers 5, 6, 7, 8, 9, 10

        //for firstNumber equal to - 5 and lastNumber equal to 5, the result should be 0 because this is the sum of numbers - 5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5

        //for firstNumber equal to 10 and lastNumber also equal to 10, the result should be 10 because, to the sum, we include the only number, which is 10

        //for firstNumber equal to 5 and lastNumber equal to 4, the result should be 0 because the lastNumber is smaller than firstNumber


            int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
        {
            if (firstNumber <= lastNumber)
            {
                int sum = 0;
                while (firstNumber <= lastNumber)
                {
                    sum += firstNumber;
                    firstNumber++;
                }
                return sum;
            }
            else
            {
                return 0;
            }
        }

        Console.WriteLine(CalculateSumOfNumbersBetween(5, 10)); 
        Console.WriteLine(CalculateSumOfNumbersBetween(-5, 5)); 
        Console.WriteLine(CalculateSumOfNumbersBetween(10, 10)); 
        Console.WriteLine(CalculateSumOfNumbersBetween(5, 4)); 
         

    }




    void SomeLoopPractice()
    {
        int number = 0;
        while(number < 10)
        {
            number++;
            Console.WriteLine($"Number is now {number}");
        }
    }

    

     void FirstPartIntro() {
        //Console.WriteLine("Hello");
        //Console.WriteLine("[S]ee all TODOS");
        //Console.WriteLine("[A]dd a TODO");
        //Console.WriteLine("[R]emove a TODO");
        //Console.WriteLine("[E]xit");

        string userInput = Console.ReadLine();

        //Console.WriteLine("Uset input: " + userInput);
        if (isOverTenLetter(userInput))
        {
            Console.WriteLine("it's over 10!");
        }
        else
        {
            Console.WriteLine("below 10...");
        }

        //GET USER INPUT AS A NUMBER:
        Console.WriteLine("Enter number 1-10 ?");
        int userNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("User number = " + userNumber);




        bool isOverTenLetter(string s)
        {
            return s.Length > 10; // can further be simplified. 
            //    if (s.Length > 10)
            //    {
            //        return true; //note on return won't hit another line of code hence can shorten the code/cleanup code 
            //    }
            //    return false;
        }
    }
}
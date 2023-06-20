using System.Net.NetworkInformation;
using System.Xml.Serialization;
using System.Collections.Generic;

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
        //program.ArrayPractice();
        //program.MultiDimensionalArraysPractice();
        //program.TwoDimensionalChallengeUdemy();
        //program.ForEachLoopPractice();
        //program.TimeForListsCollectionPractice();

        bool numberSuccess;
        int userNumber;
        
        do
        {
            Console.WriteLine("Enter a number: ");
            numberSuccess = int.TryParse(Console.ReadLine(), out userNumber);

        } while (!numberSuccess);

        Console.WriteLine($"User entered a valid number of {userNumber}");



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

    void TimeForListsCollectionPractice()
    {
         List<string> GetOnlyUpperCaseWords(List<string> words)
        {
            List<string> UpperCaseList = new List<string>();
            bool hasSpecialCharacters = false;
            foreach(string word in words)
            {
                if (!(UpperCaseList.Contains(word)))
                {
                    foreach(char c in word)
                    {
                        if (!Char.IsLetter(c)){
                            hasSpecialCharacters = true;
                            break;
                        }
                    }
                    if(!hasSpecialCharacters && (word == word.ToUpper()))
                    UpperCaseList.Add(word);
                }
            }
            return UpperCaseList;
        }


        //List<string> words = new List<string> { "one", "TWO", "THREE", "four" };
        //List<string> words = new List<string> { "one", "TWO", "THREE", "TWO" };
        List<string> words = new List<string> { "one", "TWO123", "THREE!&^", "four" };


        GetOnlyUpperCaseWords(words);
        foreach(string upper in GetOnlyUpperCaseWords(words))
        {
            Console.WriteLine(upper);
        }




        //List<string> words = new List<string>();
        //Console.WriteLine($"Amount of items in list: {words.Count}"); // 0
        //words.Add("Hello");
        //Console.WriteLine($"Amount of items in list: {words.Count}"); // 1 
        ////Note declaring type <string> means it can only hold strings 
        ////Note that lists work the same in regards to the index as with arrays
        //words[0] = "World!";
        //Console.WriteLine($"Amount of items in list: {words.Count}"); // 1 
        //Console.WriteLine($"Hello was replaced with: {words[0]}");

        //List<string> anotherListOfStrings = new List<string> { "one", "two", "three" };
        //foreach (string word in anotherListOfStrings)
        //{
        //    Console.WriteLine(word);
        //} //again if no need for the index use foreach loop if index is needed can use for loop

        ////Remove("What you want to remove") 
        ////Add("what you want to add")
        ////RemoveAt(indexOfwhatToRemove)
        ////IndexOf("thingyouarelookingfor") - will return -1 if not found in list
        ////Contains("whatyouarelookingfor") - will return a boolean value
        ////Clear() would clear the list. . .

        //List<string> myList = new List<string>();
        //myList.AddRange(new[] { "three", "four", "five","six","seven","eight" });
        //Console.WriteLine($"Count of items in my list: {myList.Count}");
        //Console.WriteLine("Items printed out in my list: ");
        //int counter = 1;
        //foreach (var item in myList)
        //{
        //    Console.WriteLine($"{counter++} {item}");
        //}

    }

    void ForEachLoopPractice()
    {
        bool IsAnyWordLongerThan(int length, string[] words)
        {
            foreach  (string word in words)
            {
                if (word.Length > length)
                    return true;
            }
            return false;
        }

        string[] words = { "aaa", "bbbb", "ccccc"};
        Console.WriteLine(IsAnyWordLongerThan(5, words)); 

        //string[] words = { "one", "two", "three", "four", "five" };

        //foreach (string word in words)
        //{
        //    Console.WriteLine(word);
        //}
        ////note that with ForEach you will not have access to the index!
    }




    void TwoDimensionalChallengeUdemy()
    {
        int FindMax(int[,] numbers)
        {
            if(numbers.GetLength(0) == 0 || numbers.GetLength(1) == 0)
            {
                return -1;
            }
            
            int maxNumber = int.MinValue;
            for(int row = 0; row < numbers.GetLength(0); row++)
            {
                for(int col = 0; col < numbers.GetLength(1); col++)
                {
                    if (numbers[row,col] > maxNumber)
                    {
                        maxNumber = numbers[row,col];
                    }
                }
            }
            return maxNumber;
        }

        int[,] testCaseArray = {
            { 3 , 5 },
            { -1 , 12 },
            { 4 , 0 }
        };

        Console.WriteLine($"Max number in the two dimensional array is: {FindMax(testCaseArray)}"); 
    }





    void MultiDimensionalArraysPractice()
    {
        //create a 2D array and initialize values
        int[,] myTwoDimensionalArray = new int[3,4] {  
            {5,4,7,3 },
            {7,3,2,6 },
            {5,3,7,3 }  //NOTE: first think of the 3 rows then create the 3x{} then add the 4 columns to each{}
        }; // 3 rows and 4 columns
           //myTwoDimensionalArray[0, 2] = 5; // index 0 in the row and index 2 in the column 
           //Console.WriteLine(myTwoDimensionalArray[0,2]); //prints 5 
           //lets rather initialize the 2D array 
        Console.WriteLine($"2D array Length propery = {myTwoDimensionalArray.Length}"); //12 is returned as length !! all of it
        //Console.WriteLine(myTwoDimensionalArray[0].Length); NOTE THIS DOES NOT WORK ON A 2D ARRAY !!!!!!
        //you have to use the getLenght() method and pass it an index 

        Console.WriteLine("LENGTH IN TWO DIMENSIONAL ARRAY");
        Console.WriteLine($"Two dimensional array getLength(0) = {myTwoDimensionalArray.GetLength(0)}"); //ROW = 3
        Console.WriteLine($"Two dimensional array getLength(1) = {myTwoDimensionalArray.GetLength(1)}"); //COLUMN = 4
        //PRINT 2D ARRAY TO CONSOLE
        Console.WriteLine("PRINT 2D ARRAY TO CONSOLE:");
        for(int row = 0; row < myTwoDimensionalArray.GetLength(0); row++)
        {
            for(int col = 0; col < myTwoDimensionalArray.GetLength(1); col++)
            {
                Console.Write(myTwoDimensionalArray[row,col] + "\t"); //note syntax here!! 2D
            }
            Console.WriteLine();
        }

        //CREAET A JAGGED ARRAY and initialize values
        int[][] myJaggedArray = {
        new int[] { 5, 4, 7, 3 },
        new int[] { 7, 3, 2, 6, 7, 4, 2, 4 }, //NOTE jagged do not have to be the same length 2D has to be! 
        new int[] { 5, 3, 7, 3 }
        };

        //Console.WriteLine(myJaggedArray[1][6]); //prints 6 [row index 1][columns index 6]
        Console.WriteLine($"Jagged array Length property = {myJaggedArray.Length}"); //This only returns 3 - the rows
        Console.WriteLine($"Jagged array at index 1 Length property = {myJaggedArray[1].Length}");
        //the above returns 8 the length of the selected index row

        //LOOPING OVER THE JAGGED ARRAY 
        Console.WriteLine("PRINT JAGGEDARRAY TO CONSOLE:");
        for (int i = 0; i < myJaggedArray.Length; i++)
        {
            for (int j = 0; j < myJaggedArray[i].Length; j++)
            {
                Console.Write($"{myJaggedArray[i][j]} \t");
            }
            Console.WriteLine();
        }
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
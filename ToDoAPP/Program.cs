using System.Collections.Generic;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        Program program = new Program();
        program.PrintMessage();

    }

    void ShowList(List<string> todoList)
    {
        Program program = new Program();

        if (!todoList.Any())
        {
            Console.Clear();
            Console.WriteLine("No TODOs have been added yet");
        }
        else
        {
            Console.WriteLine("LIST OF CURRENT TODOs:");
            for (int i = 0; i < todoList.Count; i++)
            {
                Console.WriteLine($"{i + 1} {todoList[i]}");
            }
            Console.WriteLine("*************************");
        }
        program.PrintMessage();
    }

    void PrintMessage()
    {
        Program program = new Program();

        Console.WriteLine("Hello!");
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("[S]ee all TODOs");
        Console.WriteLine("[A]dd a TODO");
        Console.WriteLine("[R]emove a TODO");
        Console.WriteLine("[E]xit");

        string userInput = "";
        bool isCorrectInput = true;

        do
        {
            userInput = Console.ReadLine();
            isCorrectInput = program.CheckForCorrectUserInput(userInput);
        } while (!isCorrectInput);

    }

    bool CheckForCorrectUserInput(string userInput)
    {
        Program program = new Program();
        List<string> todoList = new List<string>() { "Finish learning C#", "Focus on js and SQL second", "Learn the flutter framework" };

        switch (userInput.ToUpper())
        {
            case "S":
                Console.Clear();
                ShowList(todoList);
                    return true;
            case "A":
                program.AddATodo(ref todoList);
                return true;
            case "R":
                Console.WriteLine("REMOVE TODO");
                return true;
            case "E":
                Environment.Exit(0);
                return true;
            default:
                Console.Clear();
                Console.WriteLine("WRONG INPUT TRY AGAIN");
                program.PrintMessage();
                return false;
        }
    }

    void AddATodo(ref List<String> todoList)
    {
        Program program = new Program();
        Console.Clear();
        Console.WriteLine("Enter the TODO Description: ");
        string userTodo = Console.ReadLine();
        if(userTodo == "" )
        {
            Console.WriteLine("Cannot add an empty TODO...Try Again");
        }
        else
        {
            todoList.Add(userTodo);
            Console.Clear();
            Console.WriteLine("TODO ADDED SUCCESSFULLY");
            program.PrintMessage();
        }
    }

}
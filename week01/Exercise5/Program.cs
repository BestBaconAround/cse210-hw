using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int square = SquareNumber(userNumber);
        DisplayResult(userName, square);
    }
        //greets the user
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        //asks the user for their name
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            return Console.ReadLine();
        }
        //asks the user for their favorite number
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            return int.Parse(Console.ReadLine());
        }
        //squares the user's favorite number
        static int SquareNumber(int userNumber)
        {
            return userNumber * userNumber;
        }
        //outputs user's name and favorite number squared.
        static void DisplayResult(string userName, int result)
    {
        Console.WriteLine($"{userName}, the square of your number is {result}");
        
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        //user guess starts at -1 for loop
        int numGuess = -1;
        //computer creates a random number
        Random rng = new();
        int randNum = rng.Next(0, 101);

        while (numGuess != randNum)
        {
            //gets the users number guess
            Console.Write("What is the magic number? ");
            string userInput = Console.ReadLine();
            //checks if input is valid int
            if (!int.TryParse(userInput, out numGuess))
            {
                Console.WriteLine("Enter a valid number.");
                continue;
            }
            //checks user input if its higher or lower
            if (numGuess > randNum)
            {
                Console.WriteLine("Lower");
            }
            else if (numGuess < randNum)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine($"Correct! the computer guess is {randNum}. Your guess was {userInput}");
            }
        }
    }
}
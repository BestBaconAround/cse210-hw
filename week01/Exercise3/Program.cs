using System;
class Practice
{
    static void Main(string[] args)
    {
       Random rng = new Random();
       int randNum = rng.Next(0, 101);
       int numGuess = -1;

        while (numGuess != randNum)
        {
            Console.WriteLine("Pick a number! ");
            string userInput = Console.ReadLine();

            if (!int.TryParse(userInput, out numGuess))
            {
                Console.WriteLine("Enter a valid number!");
                continue;
            }
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
                Console.WriteLine("You got it!");
                break;
            }
        }
    }
}
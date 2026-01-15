using System;

class Program
{
    static void Main(string[] args)
    {
        //get user's grade
        Console.WriteLine("What is your grade? ");
        string userGrade = Console.ReadLine();
        //user grade
        int grade = int.Parse(userGrade);
        //creates the letter grade
        string letter;
        //checks grade and outputs letter
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        //checks if the user passes or fails the class
        if (grade >= 70)
        {
            Console.WriteLine($"You Passed the course with a {letter}!");
        }
        else
        {
            Console.WriteLine("Don't give up! Study harder and try again!");
        }
    }
}
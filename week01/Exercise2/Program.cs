using System;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("What is your grade: ");
      string grade = Console.ReadLine();
      int userGrade = int.Parse(grade);
      string letter;

      if (userGrade >= 90)
        {
            letter = "A";
        }
        else if (userGrade >= 80)
        {
            letter = "B";
        }
        else if (userGrade >= 70)
        {
            letter = "C";
        }
        else if (userGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (userGrade >= 70)
        {
            Console.WriteLine($"You have a passing grade of {letter}");
        }
        else
        {
            Console.WriteLine($"You failed with a {letter} grade!");
        }

    }
}
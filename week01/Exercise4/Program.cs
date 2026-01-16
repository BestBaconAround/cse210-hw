using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
// asks the user for a list of numbers
        List<int> numbers = new();
        int sum = 0;
        while (true)
        {
            Console.Write("Enter a number (0 to finish): ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int userInput))
            {
                Console.WriteLine("Invalid number.");
                continue;
            }

            if (userInput == 0)
            {
                break;
            }

            numbers.Add(userInput);
        }
// gets the average number
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine($"The sum is: {sum}");

        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");
// gets the biggest number
        int max = numbers[0];
        foreach (int n in numbers)
        {
            if (n > max)
            {
                max = n;
            }
        }
        Console.WriteLine($"The biggest number is: {max}");
// gets the smallest postitve number
        int? smallestPositive = null;
        foreach (int n in numbers)
        {
            if (n > 0)
            {
                if(smallestPositive == null || n < smallestPositive)
                {
                    smallestPositive = n;
                }
            }
        }
        Console.WriteLine($"Smallest positive number is: {smallestPositive}");
// gets the sorted list
        numbers.Sort();
        foreach (int n in numbers)
        {
            Console.WriteLine($"The sorted list is: {n}");
        }

    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the list to store the numbers
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Variable to hold the user's input
        int inputNumber = -1;

        // Keep asking for numbers until they enter 0
        while (inputNumber != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            inputNumber = int.Parse(userInput);

            // Don't add the 0 to our list
            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }
        }

        // Part 1: Calculate the Sum
        int totalSum = 0;
        foreach (int x in numbers)
        {
            totalSum += x;
        }
        Console.WriteLine($"The sum is: {totalSum}");

        // Part 2: Calculate the Average
        // We need to use (float) or (double) so it doesn't do integer division
        float average = ((float)totalSum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3: Find the Max
        // Start with the first number in the list as the current max
        int highestNumber = numbers[0];

        foreach (int n in numbers)
        {
            if (n > highestNumber)
            {
                highestNumber = n;
            }
        }
        Console.WriteLine($"The largest number is: {highestNumber}");
    }
}
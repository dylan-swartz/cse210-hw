using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Call Welcome function
        DisplayWelcome();

        // 2. Call name function and save return value
        string userName = PromptUserName();

        // 3. Call number function and save return value
        int userNumber = PromptUserNumber();

        // 4. Call birth year function using the 'out' parameter
        int birthYear;
        PromptUserBirthYear(out birthYear);

        // 5. Call square function and save return value
        int squaredNumber = SquareNumber(userNumber);

        // 6. Call display function to show the final results
        DisplayResult(userName, squaredNumber, birthYear);
    }

    // Displays a simple welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Asks for the user's name and returns it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Asks for favorite number and returns it as an integer
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Uses an 'out' parameter to provide the birth year back to Main
    static void PromptUserBirthYear(out int year)
    {
        Console.Write("Please enter the year you were born: ");
        year = int.Parse(Console.ReadLine());
    }

    // Squares a number and returns the result
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    // Calculates age based on the current year (2025) and displays results
    static void DisplayResult(string name, int square, int birthYear)
    {
        // Calculate age for the current year
        int currentYear = 2025;
        int age = currentYear - birthYear;

        Console.WriteLine($"{name}, the square of your number is {square}");
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
}
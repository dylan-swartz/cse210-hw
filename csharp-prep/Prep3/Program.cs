using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1 & 3: Generate the random magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        // This makes a loop until you get it right
        while (guess != magicNumber)
        {
            // Ask for the guess
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();
            guess = int.Parse(input);

            // tells them if they need to go higher lower and if they guessed it
            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
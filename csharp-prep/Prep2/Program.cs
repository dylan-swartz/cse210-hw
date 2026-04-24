Console.Write("What is your grade percentage? ");
string userInput = Console.ReadLine();
int grade = int.Parse(userInput);

// Determine letter grade
string letter;

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

// Determine sign (stretch challenge)
int lastDigit = grade % 10;
string sign;

if (letter == "F")
{
    sign = "";
}
else if (letter == "A" && lastDigit >= 7)
{
    sign = "";  // No A+
}
else if (lastDigit >= 7)
{
    sign = "+";
}
else if (lastDigit < 3)
{
    sign = "-";
}
else
{
    sign = "";
}

Console.WriteLine($"Your letter grade is: {letter}{sign}");

// Pass/fail message
if (grade >= 70)
{
    Console.WriteLine("Congratulations, you passed the course!");
}
else
{
    Console.WriteLine("You did not pass. Better luck next time!");
}
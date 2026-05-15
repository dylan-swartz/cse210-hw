class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool running = true;

        while (running)
        {
            // Show the menu options
            Console.WriteLine("\n1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            // Call the right Journal method based on user's choice
            switch (choice)
            {
                case "1": journal.WriteEntry(); break;
                case "2": journal.DisplayJournal(); break;
                case "3":
                    Console.Write("Enter filename: ");
                    journal.SaveToFile(Console.ReadLine());
                    break;
                case "4":
                    Console.Write("Enter filename: ");
                    journal.LoadFromFile(Console.ReadLine());
                    break;
                case "5": running = false; break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }
}
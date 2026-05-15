public class Journal
{
    // Stores all the entries and the list of prompts
    private List<Entry> _entries = new List<Entry>();
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I talked to today?",
        "What was the best part of my day?",
        "What was the strongest emotion I felt today?",
        "If I could do one thing over today, what would it be?",
        "What am I grateful for today?"
    };

    // Picks a random prompt, gets response, saves as new Entry
    public void WriteEntry()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        string date = DateTime.Now.ToShortDateString();

        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        _entries.Add(new Entry(date, prompt, response));
    }

    // Loops through entries and prints each one
    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.GetEntryText());
        }
    }

    // Saves all entries to a file, one line each
    public void SaveToFile(string filename)
    {
        using StreamWriter writer = new StreamWriter(filename);
        foreach (Entry entry in _entries)
        {
            writer.WriteLine(entry.ToFileString());
        }
    }

    // Clears current entries, reads file and rebuilds them
    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            _entries.Add(Entry.FromFileString(line));
        }
    }
}
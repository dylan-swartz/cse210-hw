public class Entry
{
    // Member variables — store the data for one entry
    private string _date;
    private string _prompt;
    private string _response;

    // Constructor — called when you do: new Entry(date, prompt, response)
    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    // Returns a readable string to display on screen
    public string GetEntryText()
    {
        return $"Date: {_date} | Prompt: {_prompt}\nResponse: {_response}";
    }

    // Returns a pipe-separated string to save to a file
    public string ToFileString()
    {
        return $"{_date}|{_prompt}|{_response}";
    }

    // Rebuilds an Entry from a saved file line
    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split('|');
        return new Entry(parts[0], parts[1], parts[2]);
    }
}
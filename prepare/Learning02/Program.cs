using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator prompts = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Write New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice) // figured out switch would be best here
            {
                case "1":
                    string prompt = prompts.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();
                    Entry entry = new Entry(prompt, response, date);
                    journal.AddEntry(entry);
                    Console.WriteLine("Entry added!\n");
                    break;

                case "2":
                    journal.DisplayAllEntries();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveJournal(saveFile);
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadJournal(loadFile);
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.\n");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}

class Entry
{
    private readonly string _prompt;
    private readonly string _response;
    private readonly string _date;

    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    public string GetEntryDisplay()
    {
        return $"{_date}\n{_prompt}\n{_response}\n";
    }

    public string SaveFileFormat()
    {
        return $"{_date}|{_prompt}|{_response}";
    }
}

class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAllEntries()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry.GetEntryDisplay());
        }
    }

    public void SaveJournal(string filename)
    {
        using StreamWriter writer = new StreamWriter(filename);
        foreach (var entry in _entries)
        {
            writer.WriteLine(entry.SaveFileFormat());
        }
        Console.WriteLine("Journal saved successfully!\n");
    }

    public void LoadJournal(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        _entries.Clear();
        foreach (var line in File.ReadAllLines(filename))
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                _entries.Add(new Entry(parts[1], parts[2], parts[0]));
            }
        }
        Console.WriteLine("Journal loaded successfully!\n");
    }
}

class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What made you smile today?",
        "Describe a challenge you faced today.",
        "What are you grateful for today?",
        "What is one thing you learned today?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
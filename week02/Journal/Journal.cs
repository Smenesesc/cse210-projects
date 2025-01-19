using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries;
    private List<Entry> importantEntries; // Separate list for important entries

    public Journal()
    {
        entries = new List<Entry>();
        importantEntries = new List<Entry>();
    }

    public void AddEntry(string prompt, string response, bool isImportant = false)
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        var entry = new Entry(date, prompt, response, isImportant);
        entries.Add(entry);

        if (isImportant)
        {
            importantEntries.Add(entry);
        }
    }

    // Display all entries
    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    // Display important entries
    public void DisplayImportantEntries()
    {
        if (importantEntries.Count == 0)
        {
            Console.WriteLine("No important entries found.");
            return;
        }

        foreach (var entry in importantEntries)
        {
            Console.WriteLine(entry);
        }
    }

    // Randomly display a past entry
    public void ShowRandomEntryForReflection()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries to reflect on.");
            return;
        }

        Random rand = new Random();
        var randomEntry = entries[rand.Next(entries.Count)];
        Console.WriteLine("Reflection Prompt: Here's a random entry from your past journal:\n");
        Console.WriteLine(randomEntry);
    }

    // Save journal to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}|{entry.IsImportant}");
            }
        }
        Console.WriteLine($"Journal saved to {filename}");
    }

    // Load journal from a file
    public void LoadFromFile(string filename)
    {
        entries.Clear();
        importantEntries.Clear();

        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 4)
                    {
                        bool isImportant = bool.Parse(parts[3]);
                        entries.Add(new Entry(parts[0], parts[1], parts[2], isImportant));
                        if (isImportant)
                        {
                            importantEntries.Add(new Entry(parts[0], parts[1], parts[2], isImportant));
                        }
                    }
                }
            }
            Console.WriteLine("Journal loaded from file.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File '{filename}' not found.");
        }
    }
}

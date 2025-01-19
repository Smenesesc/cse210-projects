/// For creativity I thought that one problem that someone could have is thinking that they are never going to read their journal so to fix that I added code to adress that by marking entries as "important" and showing a random past entry for reflection.

using System;

class Program
{
    private static Journal journal = new Journal();
    private static string[] prompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "What was the most meaningful thing in your day?"
    };

    public static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Journal Program");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Display important entries");
            Console.WriteLine("4. Show random journal entry for reflection");
            Console.WriteLine("5. Save journal to file");
            Console.WriteLine("6. Load journal from file");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "3":
                    journal.DisplayImportantEntries();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "4":
                    journal.ShowRandomEntryForReflection();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "5":
                    SaveJournal();
                    break;
                case "6":
                    LoadJournal();
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private static void WriteNewEntry()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        Console.Write("Mark this entry as important? (y/n): ");
        bool isImportant = Console.ReadLine()?.ToLower() == "y";

        journal.AddEntry(prompt, response, isImportant);
        Console.WriteLine("Entry saved. Press any key to continue...");
        Console.ReadKey();
    }

    private static void SaveJournal()
    {
        Console.Write("Enter filename to save the journal: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    private static void LoadJournal()
    {
        Console.Write("Enter filename to load the journal: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}

using System;
using System.Collections.Generic;

class Program
{
    public class Word
    {
        public string Text { get; private set; }
        public bool IsHidden { get; private set; }

        public Word(string text)
        {
            Text = text;
            IsHidden = false;
        }

        public void Hide()
        {
            IsHidden = true;
        }

        public string GetDisplayText()
        {
            return IsHidden ? new string('_', Text.Length) : Text;
        }
    }

    public class Reference
    {
        public string ReferenceText { get; private set; }

        public Reference(string referenceText)
        {
            ReferenceText = referenceText;
        }
    }

    public class Scripture
    {
        public Reference Reference { get; private set; }
        private List<Word> Words;

        public Scripture(string referenceText, string scriptureText)
        {
            Reference = new Reference(referenceText);
            Words = new List<Word>();

            foreach (var word in scriptureText.Split(' '))
            {
                Words.Add(new Word(word));
            }
        }

        public void DisplayScripture()
        {
            Console.Clear();
            Console.WriteLine(Reference.ReferenceText);
            foreach (var word in Words)
            {
                Console.Write(word.GetDisplayText() + " ");
            }
            Console.WriteLine();
        }

        public bool HideRandomWord()
        {
            var random = new Random();
            var visibleWords = Words.FindAll(w => !w.IsHidden);
            if (visibleWords.Count == 0)
                return false;

            var randomWord = visibleWords[random.Next(visibleWords.Count)];
            randomWord.Hide();
            return true;
        }

        public bool AllWordsHidden()
        {
            return Words.TrueForAll(w => w.IsHidden);
        }
    }

    public class ScriptureLibrary
    {
        private List<Scripture> scriptures;
        private Random random;

        public ScriptureLibrary()
        {
            scriptures = new List<Scripture>();
            random = new Random();
        }

        public void AddScripture(Scripture scripture)
        {
            scriptures.Add(scripture);
        }

        public Scripture GetRandomScripture()
        {
            if (scriptures.Count == 0)
                throw new InvalidOperationException("No scriptures in library.");

            int index = random.Next(scriptures.Count);
            return scriptures[index];
        }
    }

    static void Main(string[] args)
    {
        var scriptureLibrary = new ScriptureLibrary();

        scriptureLibrary.AddScripture(new Scripture("John 3:16", "For God so loved the world that He gave His only Son"));
        scriptureLibrary.AddScripture(new Scripture("Proverbs 3:5-6", "Trust in the Lord with all your heart and lean not on your own understanding"));
        scriptureLibrary.AddScripture(new Scripture("Romans 8:28", "And we know that in all things God works for the good of those who love Him, who have been called according to His purpose"));

        while (true)
        {
            var scripture = scriptureLibrary.GetRandomScripture();
            scripture.DisplayScripture();

            while (true)
            {
                Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "quit")
                {
                    return;
                }
                else
                {
                    if (scripture.HideRandomWord())
                    {
                        scripture.DisplayScripture();
                    }

                    if (scripture.AllWordsHidden())
                    {
                        Console.WriteLine("All words are hidden. The scripture is completely memorized!");
                        break;
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;

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

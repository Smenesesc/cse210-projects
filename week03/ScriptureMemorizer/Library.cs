using System;
using System.Collections.Generic;

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

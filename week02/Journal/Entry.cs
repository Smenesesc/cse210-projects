using System;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
    public bool IsImportant { get; set; } //mark important entries

    public Entry(string date, string prompt, string response, bool isImportant = false)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
        IsImportant = isImportant;
    }

    public override string ToString()
    {
        return $"{Date} - {Prompt}\n{Response}\n" + (IsImportant ? "[Important]" : "");
    }
}

using System;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    // These read-only properties let Journal save/load cleanly
    // without exposing member variables directly.
    public string Date => _date;
    public string PromptText => _promptText;
    public string EntryText => _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}

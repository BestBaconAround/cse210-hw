using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries yet.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        string separator = "~|~";

        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry.Date}{separator}{entry.PromptText}{separator}{entry.EntryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string separator = "~|~";

        string[] lines = File.ReadAllLines(file);

        _entries.Clear();

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }

            string[] parts = line.Split(separator);

            if (parts.Length < 3)
            {
                continue;
            }

            string date = parts[0];
            string prompt = parts[1];

            string entryText = string.Join(separator, parts, 2, parts.Length - 2);

            Entry entry = new Entry(date, prompt, entryText);
            _entries.Add(entry);
        }
    }
}

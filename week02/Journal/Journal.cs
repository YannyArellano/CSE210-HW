using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry.Date}|{entry.PromtText}|{entry.EntryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string date = parts[0];
            string promt = parts[1];
            string text = parts[2];

            Entry entry = new Entry(date, promt, text);
            _entries.Add(entry);
        }

    }
}
using System;
using System.Collections.Generic;
using System.IO;
public class Entry
{
    private string _date;
    private string _promtText;
    private string _entryText;

    public Entry(string date, string promtText, string entryText)
    {
        _date = date;
        _promtText = promtText;
        _entryText = entryText;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"PromtText: {_promtText}");
        Console.WriteLine($"Entry {_entryText}");
        Console.WriteLine();
    }

    public string Date => _date;
    public string PromtText => _promtText;
    public string EntryText => _entryText;
}
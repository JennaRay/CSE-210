using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries;
    public string _fileName;

    public Journal()
    {
        _entries = new List<Entry>{};
    }
    public Journal(string file)
    {
        _fileName = file;
        _entries = new List<Entry>{};
    }

    public void Load()
    {   if (!File.Exists(_fileName))
        {
            using (FileStream fs = File.Create(_fileName)){}
        }
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        List<string> entries = new List<string>();
        foreach (string line in lines)
        {
            string[] parts = line.Split("~~~");
            string date = parts[0];
            string prompt = parts[1];
            string content = parts[2];
            Entry entry = new Entry(date, prompt, content);
            _entries.Add(entry);

        }
    }

    public void Save()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},");
                outputFile.WriteLine($"{entry._prompt},");
                outputFile.WriteLine($"{entry._text},");
                outputFile.WriteLine("~~~");
            }
        }
    }

    public void NewEntry()
    {
        Entry entry = new Entry();
        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry._date);
            Console.WriteLine(entry._prompt);
            Console.WriteLine(entry._text);
            Console.WriteLine();
        }
    }

}
using System;
using System.IO;

class Menu
{
    static void DisplayMenu()
    {   List<string> _menu = new List<string>() 
        {
            "New Entry",
            "Display Journal",
            "Load Journal",
            "Save Journal",
            "Quit"
        };
        int number = 0;
        foreach (string option in _menu)
        {   
            number += 1;
            Console.WriteLine($"\n{number}. {option}");
        }
    }
    public static int PromptMenu()
    {   
        DisplayMenu();
        Console.Write("What would you like to do?: ");
        bool asking = true;
        int choice = 0;
        while (asking) {
            choice = int.Parse(Console.ReadLine());
            if (choice < 1 || choice > 5) {
                Console.Write("Please enter a valid option");
                asking = true;
                }
            else {
                asking = false;
                }
        }
        return choice;
    }    
}

class Prompt
{   
    public string _text = GeneratePrompt();
    static void DisplayPrompt(string prompt)
    {
        Console.WriteLine(prompt);
    }
    static string GeneratePrompt()
    {
        List<string> _prompts = new List<string>()
        {
            "Who was the most interesting person you talked to today?",
            "What are you most proud of accomplishing today?",
            "What did you dream about last night?",
            "Who/what inspired you today?",
            "What did you learn today?",
            "What media did you consume today and what did you think about it?",
            "What do you want to do differently tomorrow?",
            "Rate your day on a scale of 1-10 and explain why you chose that rating."
        };

        Random rnd = new Random();
        int length = _prompts.Count();
        string prompt = _prompts[rnd.Next(length)];
        DisplayPrompt(prompt);
        return prompt;
    }

}
public class Entry
{
    string _date;
    string _prompt;
    string _text;

    public static string CreateEntry()
    {   Entry newEntry = new Entry();
        DateTime date = DateTime.Now.Date;
        newEntry._date = date.ToShortDateString();
        newEntry._prompt = GetPrompt();
        newEntry._text = Write();
        string compiledEntry = newEntry._date + "~~~" + newEntry._prompt + "~~~" + newEntry._text + "***";
        return compiledEntry;
    }
    static string GetPrompt()
    {
        Prompt newPrompt = new Prompt();
        return newPrompt._text;
    }

    static string Write()
    {
        string text = Console.ReadLine();
        return text;
    }

}
public class Journal
{
    public String[] _localJournal;

    public static string[] Load(string _fileName)
    {   
        using FileStream fileStream = File.Open(_fileName, FileMode.Append);
        using StreamWriter file = new StreamWriter(fileStream);
        string[] content = System.IO.File.ReadAllLines(_fileName);
        Console.Write("Journal Loaded");
        return content;
        
    }

    public static void Save(string _fileName, string[] current)
    {
            
            using(StreamWriter file = new StreamWriter(_fileName))
        {   
            file.WriteLine(current);
        }
            Console.WriteLine("Journal Saved");
    }

    public static void Display(string[] current)
    {   
        string[] lines = current;
        foreach (string line in lines)
        {   
            string[] entries = line.Split("***");
                foreach (string entry in entries)
                {
                    string[] parts = line.Split ("~~~");

                    string date = parts[0];
                    string prompt = parts[1];
                    string text = parts[2];

                    Console.WriteLine(date);
                    Console.WriteLine(prompt);
                    Console.WriteLine(text);
                    Console.WriteLine();
                }
        }
    }

    public static string CreateEntry(string _fileName)
    {
        using(StreamWriter file = new StreamWriter(_fileName))
        {   Journal journal = new Journal();
            string entry = Entry.CreateEntry();
            file.WriteLine(entry);
            return entry;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {   
        Journal current = new Journal();
        Console.WriteLine("Enter file name: ");
        string fileName = Console.ReadLine();
        bool playing = true;
        while (playing)
        {
            int action = Menu.PromptMenu();
            
            if (action != 5 )
            {
                if (action == 1)
                {   
                    if (current._localJournal == null)
                    {
                        current._localJournal = Journal.Load(fileName);
                    }
                    string entry = Journal.CreateEntry(fileName);
                    current._localJournal.Append(entry); 
                }
                else if (action == 2)
                {
                    Journal.Display(current._localJournal);
                }
                else if (action == 3) 
                {
                    current._localJournal = Journal.Load(fileName);
                }
                else if (action == 4)
                {   
                    Console.WriteLine("What file would you like to save to? ");
                    string saveFileName = Console.ReadLine();
                    Journal.Save(saveFileName, current._localJournal);
                }
            }
            else
            {
                Console.WriteLine("Ok bye");
                playing = false;
            }
        }
    }
}
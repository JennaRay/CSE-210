using System;
using System.IO;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _text;

    public Entry()
    {
        _date = GetDate();
        _prompt = new Prompt()._text;
        _text = Write();
    }

    public Entry(string date, string prompt, string content)
    {
        _date = date;
        _prompt = prompt;
        _text = content;
    }
    private string GetDate()
    {
        DateTime date = DateTime.Now.Date;
        return date.ToShortDateString();
    }

    private string Write()
    {
        string content = Console.ReadLine();
        return content;
    }
}
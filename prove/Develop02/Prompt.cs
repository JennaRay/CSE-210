using System;
using System.IO;

public class Prompt
{
    public string _text;

    public Prompt()
    {
        _text = GeneratePrompt();
    }

    private static string GeneratePrompt()
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
        Console.WriteLine(prompt);
        return prompt;
    }

}

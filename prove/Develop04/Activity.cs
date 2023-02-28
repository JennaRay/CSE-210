using System;

class Activity
{
    private string _introMessage;
    private int _userTime;
    private string _instructions;
    private string _endMessage;
    
    private List<string> _menu = new List<string>()
        {
            "Breath", 
            "Reflect", 
            "List", 
            "Quit"
        };

    public Activity(string intro, int time)
    {
        _introMessage = intro;
        _userTime = time;
    }

    void Pause(int x)
    {   
        foreach (int i in)
        Thread.Sleep(500);

        Console.Write("\b\b\b   \b\b\b");
        Console.Write("'_'");

        Thread.Sleep(500);

        Console.Write("\b\b\b   \b\b\b");
        Console.Write("^_^");
    }

    int GetTime()
    {
        Console.Write("For how many seconds would you like to do this activity? ");
        return int.Parse(Console.ReadLine());
    }

    private int DisplayMenu()
    {   
        Console.WriteLine("What would you like to do today?");
        Console.WriteLine();
        for (int i = 0; i == _menu.Count(); i += 1)
        {
            Console.WriteLine($"{i+1}. {_menu[i]}");
        }
        return int.Parse(Console.ReadLine());
    }

    public void DisplayMessage()
    {

    }
}   

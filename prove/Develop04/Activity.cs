using System;

class Activity
{
    private string _introMessage;
    protected int _userTime;
    private string _instructions;
    private string _endMessage;
    

    public Activity(string intro, string instructions)
    {
        _introMessage = intro;
        _instructions = instructions;
        _endMessage = "You have completed this activity";
    }

    protected void Pause(int x)
    {   
        Console.WriteLine();
        int i = 0;
        while (i < x)
        {
        
        Console.Write("\b \b");
        Console.Write("|");

        Thread.Sleep(100);

        Console.Write("\b \b");
        Console.Write("\\");
        
        Thread.Sleep(100);

        Console.Write("\b \b");
        Console.Write("-");

        Thread.Sleep(100);

        Console.Write("\b \b");
        Console.Write("/");
        Console.Write("\b \b");
        i += 400;
        }
        
    }

    private int GetTime()
    {
        Console.Write("For how many seconds would you like to do this activity? ");
        return int.Parse(Console.ReadLine());
    }

    protected void DisplayMessage(bool start)
    {
        if (start)
        {
            Console.WriteLine(_introMessage);
            Console.WriteLine(_instructions);
        }
        else {Console.WriteLine(_endMessage);};
    }
    protected void StartActivity()
    {
        DisplayMessage(true);
        _userTime = GetTime();
        Console.Write("Lets begin");
        Pause(3000);
        
    }

}   

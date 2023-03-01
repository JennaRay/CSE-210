using System;

class ListingActivity : Activity
{
    List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    List<string> _userList = new List<string>();
    
    public ListingActivity(string intro, string instructions) : base(intro, instructions)
    {

    }

    private string SelectPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }

    private void Countdown()
    {
        Thread.Sleep(2000);
        Console.Write("1...");
        Thread.Sleep(2000);
        Console.Write("2...");
        Thread.Sleep(2000);
        Console.WriteLine("3...");
        Console.WriteLine();
    }

    public void Run()
    {
        StartActivity();
        Console.WriteLine(SelectPrompt());

        Countdown();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_userTime);

        Thread.Sleep(3000);

        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {   
            currentTime = DateTime.Now;
            _userList.Add(Console.ReadLine());
        }
        
        Console.WriteLine();
        Console.WriteLine("Times up!");
        Console.WriteLine($"You listed {_userList.Count} things");
        Thread.Sleep(3000);

        DisplayMessage(false);
    }
}
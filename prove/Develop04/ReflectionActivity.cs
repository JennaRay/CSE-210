using System;

class ReflectionActivity : Activity
{
    List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string intro, string instructions) : base(intro, instructions)
    {
        
    }

    private string SelectPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }

    private string SelectQuestion()
    {
        Random rnd = new Random();
        int index = rnd.Next(_questions.Count);
        return _questions[index];
    }

    public void Run()
    {
        StartActivity();

        Console.WriteLine(SelectPrompt());
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_userTime);

        Thread.Sleep(5000);

        DateTime currentTime = DateTime.Now;        

        while (currentTime < futureTime)
            {   
                currentTime = DateTime.Now;
                Console.WriteLine(SelectQuestion());
                Pause(5000);
            }


        DisplayMessage(false);
    }
}
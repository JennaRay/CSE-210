using System;

class BreathingActivity : Activity
{


    public BreathingActivity(string intro, string instructions) : base(intro, instructions)
    {

    }

   public void Run()
   {
        StartActivity();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_userTime);

        Thread.Sleep(3000);

        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            Console.WriteLine();
            Console.WriteLine("Breath in...");
            Console.WriteLine();
            Pause(5000);
            Console.WriteLine();
            Console.WriteLine("Breath out...");
            Pause(5000);
        }

        DisplayMessage(false);
   }
}
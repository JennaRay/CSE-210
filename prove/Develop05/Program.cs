using System;

class Program
{
    int _userPoints;
    List<Goal> _goals = new List<Goal>{};
    string _fileName = "goals.txt";
    public void Main(string[] args)
    {   
        bool playing = true;
        Load();
        while (playing){
            int action = DisplayMenu();
            switch(action)
            {
                case 1:
                    Console.WriteLine("What kind of goal do you want to make?");
                    Console.WriteLine($"1. Simple Goal, 2. Eternal Goal, 3. Checklist Goal");
                    int answer = int.Parse(Console.ReadLine());
                    CreateGoal(answer);
                    break;
                case 2:
                    foreach (Goal goal in _goals)
                    {
                        goal.DisplayGoal();
                    }
                    break;
                case 3:
                    Console.WriteLine("Which goal are you completing? ");
                    string selected = Console.ReadLine();
                    foreach (Goal goal in _goals)
                    {
                        if (goal.CheckTitle(selected))
                        {
                            goal.SetCompleted();
                        }
                        Console.Write("Goal Completed, you've earned ");
                        goal.DisplayPoints();
                        Console.WriteLine("points.");
                    }
                    break;
                case 4:
                    Console.WriteLine($"Your score is: {_userPoints}");
                    break;
                case 5:
                    Save();
                    Console.WriteLine("Ok bye");
                    playing = false;
                    break;
            }
        }
    }

    public int DisplayMenu()
    {
        string[] menu = ["Create Goal", "View Goals", "Complete Goal", "View Score", "Quit"];
        foreach (string item in menu)
        {
            int counter = 1;
            Console.WriteLine($"{counter}. item");
            counter += 1;
        }
        Console.WriteLine($"Select and option: ");
        int selection = int.Parse(Console.ReadLine());
        return selection;
    }
    public void CreateGoal(int which)
    {   
        Console.Write("What would you like to title this goal? ");
        string title = Console.ReadLine();
        Console.Write("Write a description of the goal: ");
        string description = Console.ReadLine();
        Console.Write("How many points do you get for completing this goal?");
        int points = int.Parse(Console.ReadLine());
        if (which == 1)
        {
            _goals.Add(new Simple(points, title, description));
        }
        else if (which == 2)
        {
            _goals.Add(new Eternal(points, title, description));
        }
        else if (which == 3)
        {
            _goals.Add(new Checklist(points, title, description));
        }
    }
    public void Save()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine($"{_userPoints}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.MakeString());
            }
        }
    }

    public void Load()
    {
        if (!File.Exists(_fileName))
        {
            using (FileStream fs = File.Create(_fileName)){}
        }
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        
        int counter = 0;
        foreach (string line in lines)
        {   counter += 1;
            if (counter == 1)
            {
                _userPoints = int.Parse(line);
            }
            string[] parts = line.Split(":");
            string[] moreParts = parts[4].Split(";");
            switch (moreParts[0])
            {
                case "simple":
                    _goals.Add(new Simple(int.Parse(parts[2]), parts[0], parts[1]));
                
                case "eternal":
                    _goals.Add(new Eternal(int.Parse(parts[2]), parts[0], parts[1], moreParts[1]));

                case "checklist":
                    _goals.Add(new Checklist(int.Parse(parts[2]), parts[0], parts[1], moreParts[1]));

            }
        }
            
    }
}

using System;

class Program
{   
    string _fileName = "mealplanning.txt";
    Calander _calander = new Calander();
    User _user = new User();
    public void Main(string[] args)
    {
        bool playing = true;

        while (playing)
        {
            DisplayMenu();
        }
    }

    public void Load()
    {
        if (!File.Exists(_fileName))
        {
            using (FileStream fs = File.Create(_fileName)){}
        }
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        int count = 0;
        foreach (string line in lines)
        {
            count += 1;
            if (count == 1)
            {
                string[] parts = line.Split("||");
                _user.SetName(parts[0]);
                _user.SetWeight(parts[1]);
                _user.SetSex(parts[2]);
                _user.SetPregnant(parts[3]);
            }
            else if (count == 2)
            {
                string[] parts = line.Split("||");
                _calander.SetWeeks(parts[0]);
                _calander.SetTimers(parts[1]);
                _calander.SetMonth(parts[2]);
                _calander.SetYear(parts[3]);
            }
        }
       
    }

    public void Save()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            // line for user
            outputFile.WriteLine($"{_user.GetName()}||{_user.GetWeight}||{_user.GetSex()}||{_user.GetPregnant()} ");
            // line for calander
            outputFile.WriteLine($"{_calander.GetWeeks()}||{_calander.GetTimers()}||{_calander.GetMonth()}||{_calander.GetYear()}");

        }
    }

//Menu
    List<string> _options = new List<string>()
    {
        "View Profile",
        "View This Week's Plan",
        "View Calander",
        "View Alerts"
    };

    public void DisplayMenu()
    {   
        int count = 0;
        Console.WriteLine("Meal Planner");
        Console.WriteLine("-------------");
        foreach (string option in _options)
        {
            count += 1;
            Console.WriteLine($"{count}. {option}");
        }
        ChooseOption();
    }

    public void ChooseOption()
    {
        int selection;
        Console.WriteLine();
        Console.WriteLine("Make a selection: ");
        selection = int.Parse(Console.ReadLine());

        switch (selection)
        {
            case 1:
                ViewProfile();
                break;
            case 2:
                ViewThisWeek();
                break;
            case 3:
                ViewCalander();
                break;
            case 4:
                ViewAlerts();
                break;
        }
    }

    public void ViewProfile()
    {
        if (_user == null)
        {
            Console.WriteLine("You haven't set up a profile yet! Lets do that first.");
            _user = new User();
        }
        _user.DisplayProfile();
    }

    public void ViewThisWeek()
    {
        if (_calander == null)
        {
            Load();
        }
        _calander.DisplayThisWeek();
    }

    public void ViewCalander()
    {
        if (_calander == null)
        {
            Load();
        }
        _calander.DisplayCalander();
    }

    public void ViewAlerts()
    {
        Console.WriteLine("Sorry this feature is not ready");
    }
}
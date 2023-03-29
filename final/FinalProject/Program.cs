using System;

class Program
{
    static void Main(string[] args)
    {
        Menu.DisplayMenu();
    }
}

static class Menu
{
    List<string> _options = new List<string>()
    {
        "Create/Alter Profile",
        "View Week Plan",
        "View Calander",
        "Make Plan",
        "Change Plan",
        "View Alerts",
        "Cook"
    };

    public static void DisplayMenu()
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
                
                break;
            case 2:

                break;
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
            case 6:

                break;
            case 7:

                break;
        }
    }
}
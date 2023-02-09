using System;
using System.IO;

public class Menu
{
 private static void DisplayMenu()
    {   List<string> _menu = new List<string>() 
        {
            "New Entry",
            "Display Journal",
            "Load Journal",
            "Save Journal",
            "Quit"
        };
        int number = 0;
        foreach (string option in _menu)
        {   
            number += 1;
            Console.WriteLine($"\n{number}. {option}");
        }
    }

    public static int PromptMenu()
    {   
        DisplayMenu();
        Console.Write("What would you like to do?: ");
        bool asking = true;
        int choice = 0;
        while (asking) {
            choice = int.Parse(Console.ReadLine());
            if (choice < 1 || choice > 5) {
                Console.Write("Please enter a valid option");
                asking = true;
                }
            else {
                asking = false;
                }
        }
        return choice;
    }    
}
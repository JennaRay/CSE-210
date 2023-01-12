using System;

class Program
{
    static void Main(string[] args)
    {
       DisplayWelcome();
       string username = PromptUserName();
       int favNumber = PromptUserNumber();
       int squaredNumber = SquareNumber(favNumber);
       DisplayResult(username, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName() 
    {
        Console.WriteLine("Enter your username: ");
        string username = Console.ReadLine();
        return username;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Enter your favorite whole number: ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }

    static int SquareNumber(int number)
    {
        double square = Math.Sqrt(number);
        return Convert.ToInt32(square);
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
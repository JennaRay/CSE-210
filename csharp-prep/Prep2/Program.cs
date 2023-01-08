using System;

class Program
{
    static void Main(string[] args)
    {   string letter = "F";
        Console.Write("Enter your grade percentage:");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        if (grade >= 90) {
            letter = "A";
        }
        else if (grade >= 80) {
            letter = "B";
        }
        else if (grade >= 70) {
            letter = "C";
        }
        else if (grade >= 60) {
            letter = "D";
        }
        else {
            letter = "F";
        }
        Console.WriteLine($"Your grade is: {letter}");

        string message = "";
        if (grade >= 70) {
            message = "Congrats you passed!";
        }
        else {
            message = "You bombed this. Study better my guy";
        }
        Console.WriteLine(message);

    }
}
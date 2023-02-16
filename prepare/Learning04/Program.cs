using System;

 class Program
{
    static void Main(string[] args)
    {
        WritingAssignment test = new WritingAssignment("Jenna Ray", "Russian", "Why Russia is Cool");
        Console.WriteLine(test.GetSummary());
        Console.WriteLine(test.GetWritingInformation());


    }
}
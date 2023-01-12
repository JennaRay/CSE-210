using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input = -1;
        while (input != 0) 
        {
            Console.Write("Add a number: ");
            input = int.Parse(Console.ReadLine());
            numbers.Add(input);
        }

        int sum = 0;
        int max = 0;
        foreach (int number in numbers) 
        {
           sum += number; 

           if (number > max) 
           {
            max = number;
           }
        }
        int average = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

    }
}
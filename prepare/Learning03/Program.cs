using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(2, 6);

        Console.WriteLine(f3.GetFractionString());
        f3.SetTop(3);
        f3.SetBottom(4);
        Console.WriteLine($"{f3.GetTop()}/{f3.GetBottom()}");

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f3.GetDecimalValue());
    }
}
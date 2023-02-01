using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(2, 6);

        f3.SetTop(2);
        Console.WriteLine(f3.GetBottom());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square(8, "red");
        shapes.Add(s1);
        Circle c1 = new Circle(4, "green");
        shapes.Add(c1);
        Rectangle r1 = new Rectangle(9, 8, "blue");
        shapes.Add(r1);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}
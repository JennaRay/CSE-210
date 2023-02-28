using System;

public class Rectangle : Shape
{
    double _length;
    double _width;

    public Rectangle(double l, double w, string color) : base(color)
    {
        _length = l;
        _width = w;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}
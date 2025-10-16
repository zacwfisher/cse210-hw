using System;

public class Rectangle : Shape
{
    private double _width;
    private double _length;

    public Rectangle(string color, double length, double width) : base(color)
    {
        _width = width;
        _length = length;
    }

    public override double GetArea()
    {
        return _width * _length;
    }
}
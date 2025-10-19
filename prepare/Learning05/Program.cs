using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 5);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 3, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 7);
        shapes.Add(s3);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea():F2}\n");
        }
    }
}

// Added bonus points in my Goal.cs file for gamification purposes :)
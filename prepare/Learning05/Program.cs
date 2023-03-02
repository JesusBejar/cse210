using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();

        Square square = new Square("blue", 2);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("red", 3, 2);
        shapes.Add(rectangle);

        Circle circle = new Circle("purple", 3);
        shapes.Add(circle);

        foreach (Shape s in shapes )
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
        }
    }
}
using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square newSquare = new Square("blue", 5);
        shapes.Add(newSquare);

        Circle newCircle = new Circle("red", 7);
        shapes.Add(newCircle);

        Rectangle newRectangle = new Rectangle("green", 4, 5);
        shapes.Add(newRectangle);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}!");            
        }
    }
}
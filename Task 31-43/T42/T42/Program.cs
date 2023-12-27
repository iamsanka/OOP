using System;
using System.Collections.Generic;

abstract class Shape
{
    public string Name { get; protected set; }
    public abstract double Area { get; }
    public abstract double Circumference { get; }
}

class Circle : Shape
{
    public double Radius { get; private set; }

    public Circle(double radius)
    {
        Name = "Circle";
        Radius = radius;
    }

    public override double Area => Math.PI * Radius * Radius;

    public override double Circumference => 2 * Math.PI * Radius;
}

class Rectangle : Shape
{
    public double Width { get; private set; }
    public double Height { get; private set; }

    public Rectangle(double width, double height)
    {
        Name = "Rectangle";
        Width = width;
        Height = height;
    }

    public override double Area => Width * Height;

    public override double Circumference => 2 * (Width + Height);
}

class Shapes
{
    private List<Shape> shapeList = new List<Shape>();

    public void AddShape(Shape shape)
    {
        shapeList.Add(shape);
    }

    public void PrintShapes()
    {
        foreach (var shape in shapeList)
        {
            Console.WriteLine($"{shape.Name} {shape}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shapes shapes = new Shapes();

        Circle circle1 = new Circle(1);
        Circle circle2 = new Circle(2);
        Circle circle3 = new Circle(3);

        Rectangle rectangle1 = new Rectangle(10, 20);
        Rectangle rectangle2 = new Rectangle(20, 30);
        Rectangle rectangle3 = new Rectangle(40, 50);

        shapes.AddShape(circle1);
        shapes.AddShape(circle2);
        shapes.AddShape(circle3);
        shapes.AddShape(rectangle1);
        shapes.AddShape(rectangle2);
        shapes.AddShape(rectangle3);

        shapes.PrintShapes();

        Console.WriteLine("\nPress enter key to continue...");
        Console.ReadLine();
    }
}

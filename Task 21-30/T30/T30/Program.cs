using System;

// Define the Shape interface
public interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
    void DisplayInfo();
}

// Implement Circle class
public class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Circle - Radius: {Radius}, Area: {CalculateArea()}, Perimeter: {CalculatePerimeter()}");
    }
}

// Implement Rectangle class
public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }

    public double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Rectangle - Width: {Width}, Height: {Height}, Area: {CalculateArea()}, Perimeter: {CalculatePerimeter()}");
    }
}

// Implement Triangle class
public class Triangle : IShape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double CalculateArea()
    {
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public double CalculatePerimeter()
    {
        return SideA + SideB + SideC;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Triangle - SideA: {SideA}, SideB: {SideB}, SideC: {SideC}, Area: {CalculateArea()}, Perimeter: {CalculatePerimeter()}");
    }
}

class Program
{
    static void Main()
    {
        IShape[] shapes = new IShape[]
        {
            new Circle(5.0),
            new Rectangle(4.0, 6.0),
            new Triangle(3.0, 4.0, 5.0)
        };

        foreach (var shape in shapes)
        {
            shape.DisplayInfo();
        }
    }
}

using System;

class Window
{
    // Properties for width and height of the window
    public double Width { get; set; }
    public double Height { get; set; }

    // Constructor to initialize the width and height
    public Window(double width, double height)
    {
        Width = width;
        Height = height;
    }

    // Method to calculate the area of the window frame
    public double CalculateArea()
    {
        // Assuming the window frame has three layers
        // We calculate the outer frame area and subtract the area of the glass
        double outerFrameArea = Width * Height;;
        return outerFrameArea;
    }

    // Method to calculate the circumference of the window frame
    public double CalculateCircumference()
    {
        // Assuming the window frame has four sides
        return 2 * (Width + Height);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the width of the window: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Enter the height of the window: ");
        double height = double.Parse(Console.ReadLine());

        Window window = new Window(width, height);

        double area = window.CalculateArea();
        double circumference = window.CalculateCircumference();

        Console.WriteLine($"Area of the window frame: {area} square meters");
        Console.WriteLine($"Circumference of the window frame: {circumference} meters");
    }
}

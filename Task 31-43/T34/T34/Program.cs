using System;
using System.Linq;

public class ArrayCalculator
{
    public static double Sum(double[] array)
    {
        return array.Sum();
    }

    public static double Average(double[] array)
    {
        if (array.Length == 0)
            return 0;

        return array.Average();
    }

    public static double Min(double[] array)
    {
        if (array.Length == 0)
            return 0;

        return array.Min();
    }

    public static double Max(double[] array)
    {
        if (array.Length == 0)
            return 0;

        return array.Max();
    }
}

class Program
{
    static void Main()
    {
        double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };

        double sum = ArrayCalculator.Sum(array);
        double average = ArrayCalculator.Average(array);
        double min = ArrayCalculator.Min(array);
        double max = ArrayCalculator.Max(array);

        Console.WriteLine($"Sum = {sum:F2}");
        Console.WriteLine($"Ave = {average:F2}");
        Console.WriteLine($"Min = {min:F2}");
        Console.WriteLine($"Max = {max:F2}");

        Console.WriteLine("\nPress enter key to continue...");
        Console.ReadLine();
    }
}



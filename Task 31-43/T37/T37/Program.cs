using System;
using System.Collections.Generic;

class Dice
{
    private Random random;

    public Dice()
    {
        random = new Random();
    }

    public int Roll()
    {
        return random.Next(1, 7); // Generates a random number between 1 and 6
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dice dice = new Dice();

        // Roll the dice once and print the result
        int singleThrow = dice.Roll();
        Console.WriteLine($"Dice, one test throw value is {singleThrow}");
        Console.WriteLine();

        // Ask the user for the number of throws
        Console.Write("How many times you want to throw a dice: ");
        int numThrows = int.Parse(Console.ReadLine());

        // Roll the dice the specified number of times and calculate the average
        int total = 0;
        Dictionary<int, int> counts = new Dictionary<int, int>();

        for (int i = 0; i < numThrows; i++)
        {
            int result = dice.Roll();
            total += result;

            if (counts.ContainsKey(result))
            {
                counts[result]++;
            }
            else
            {
                counts[result] = 1;
            }
        }

        double average = (double)total / numThrows;

        // Print the average and the counts
        Console.WriteLine($"Dice is now thrown {numThrows} times");
        Console.WriteLine($"- average is {average:F4}");

        foreach (var kvp in counts)
        {
            Console.WriteLine($"- {kvp.Key} count is {kvp.Value}");
        }

        Console.WriteLine("\nPress enter key to continue...");
        Console.ReadLine();
    }
}

using System;

class Amplifier
{
    private int volume;

    public int Volume
    {
        get { return volume; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Too low volume - Amplifier volume is set to minimum : 0");
                volume = 0;
            }
            else if (value > 100)
            {
                Console.WriteLine("Too much volume - Amplifier volume is set to maximum : 100");
                volume = 100;
            }
            else
            {
                volume = value;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Amplifier amplifier = new Amplifier();

        while (true)
        {
            Console.Write("Give a new volume value (0-100) > ");
            if (int.TryParse(Console.ReadLine(), out int newVolume))
            {
                amplifier.Volume = newVolume;
                Console.WriteLine($"-> Amplifier volume is set to : {amplifier.Volume}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }
        }
    }
}

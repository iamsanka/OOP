using System;

class ElectricalDevice
{
    public bool On { get; set; }
    public float Power { get; set; }

    public ElectricalDevice()
    {
        On = false;
        Power = 0;
    }
}

class PortableRadio : ElectricalDevice
{
    private int volume;
    private float frequency;

    public int Volume
    {
        get
        {
            return volume;
        }
        set
        {
            if (On && value >= 0 && value <= 9)
            {
                volume = value;
            }
        }
    }

    public float Frequency
    {
        get
        {
            return frequency;
        }
        set
        {
            if (On && value >= 2000.0f && value <= 26000.0f)
            {
                frequency = value;
            }
        }
    }

    public override string ToString()
    {
        return $"Radio Settings:\n- Power: {Power} watts\n- On: {On}\n- Volume: {Volume}\n- Frequency: {Frequency}";
    }
}

class Program
{
    static void Main()
    {
        PortableRadio radio = new PortableRadio();
        Console.WriteLine("Radio Settings:");
        Console.WriteLine(radio);

        // Turn on the radio
        radio.On = true;
        radio.Power = 10.5f;
        Console.WriteLine("\nRadio Settings (After turning on):");
        Console.WriteLine(radio);

        // Set volume and frequency
        radio.Volume = 5;
        radio.Frequency = 14000.0f;
        Console.WriteLine("\nRadio Settings (After setting volume and frequency):");
        Console.WriteLine(radio);
    }
}

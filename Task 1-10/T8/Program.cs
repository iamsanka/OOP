using System;

public class Television
{
    // Auto-implemented properties for isOn, volume, and channel
    public bool IsOn { get; private set; }
    public int Volume { get; private set; }
    public int Channel { get; private set; }

    public Television()
    {
        IsOn = false;
        Volume = 10;
        Channel = 1;
    }

    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine("TV is now ON.");
    }

    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine("TV is now OFF.");
    }

    public void SetVolume(int volume)
    {
        if (IsOn)
        {
            if (volume >= 0 && volume <= 100)
            {
                Volume = volume;
                Console.WriteLine($"Volume set to {Volume}.");
            }
            else
            {
                Console.WriteLine("Volume should be between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("TV is OFF. Turn it on to adjust volume.");
        }
    }

    public void ChangeChannel(int channel)
    {
        if (IsOn)
        {
            if (channel > 0)
            {
                Channel = channel;
                Console.WriteLine($"Channel changed to {Channel}.");
            }
            else
            {
                Console.WriteLine("Channel number should be positive.");
            }
        }
        else
        {
            Console.WriteLine("TV is OFF. Turn it on to change the channel.");
        }
    }

    public int GetVolume()
    {
        return Volume;
    }

    public int GetChannel()
    {
        return Channel;
    }
}



class Program
{
    static void Main()
    {
        Television myTV = new Television();

        myTV.TurnOn();
        myTV.SetVolume(30);
        myTV.ChangeChannel(5);

        Console.WriteLine($"Current Volume: {myTV.GetVolume()}");
        Console.WriteLine($"Current Channel: {myTV.GetChannel()}");

        myTV.TurnOff();
    }
}

using System;

class Heater
{
    private bool isOn;
    private double temperature;
    private double humidity;

    public Heater()
    {
        isOn = false;
        temperature = 0.0;
        humidity = 0.0;
    }

    public void TurnOn()
    {
        isOn = true;
    }

    public void TurnOff()
    {
        isOn = false;
    }

    public void SetTemperature(double newTemperature)
    {
        if (isOn)
        {
            temperature = newTemperature;
        }
    }

    public void SetHumidity(double newHumidity)
    {
        if (isOn)
        {
            humidity = newHumidity;
        }
    }

    public bool IsOn
    {
        get { return isOn; }
    }

    public double Temperature
    {
        get { return temperature; }
    }

    public double Humidity
    {
        get { return humidity; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Heater saunaHeater = new Heater();

        // Turn on the heater
        saunaHeater.TurnOn();
        Console.WriteLine("Heater is turned on.");

        // Set temperature and humidity
        saunaHeater.SetTemperature(80.0);
        saunaHeater.SetHumidity(30.0);

        // Display the status
        Console.WriteLine($"Temperature: {saunaHeater.Temperature}°C");
        Console.WriteLine($"Humidity: {saunaHeater.Humidity}%");

        // Turn off the heater
        saunaHeater.TurnOff();
        Console.WriteLine("Heater is turned off.");

        // Try to set temperature and humidity when the heater is off
        saunaHeater.SetTemperature(90.0);
        saunaHeater.SetHumidity(40.0);

        // Display the status again
        Console.WriteLine($"Temperature: {saunaHeater.Temperature}°C");
        Console.WriteLine($"Humidity: {saunaHeater.Humidity}%");
    }
}

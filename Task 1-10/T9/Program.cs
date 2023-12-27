using System;

public class Vehicle
{
    // Auto-implemented properties
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Speed { get; set; }
    public int Tires { get; set; }

    // Constructor
    public Vehicle(string brand, string model, int speed, int tires)
    {
        Brand = brand;
        Model = model;
        Speed = speed;
        Tires = tires;
    }

    // Method to show manufacturer and model information
    public string ShowInfo()
    {
        return $"Manufacturer: {Brand}, Model: {Model}";
    }

    // Override ToString() to display all properties
    public override string ToString()
    {
        return $"Manufacturer: {Brand}, Model: {Model}, Speed: {Speed} km/h, Tires: {Tires}";
    }
}


class Program
{
    static void Main()
    {
        // Create two Vehicle objects
        Vehicle vehicle1 = new Vehicle("Honda", "Civic", 120, 4);
        Vehicle vehicle2 = new Vehicle("Toyota", "Camry", 110, 4);

        // Print information using ShowInfo method
        Console.WriteLine("Vehicle 1 Information:");
        Console.WriteLine(vehicle1.ShowInfo());

        Console.WriteLine("\nVehicle 2 Information:");
        Console.WriteLine(vehicle2.ShowInfo());

        // Change object properties
        vehicle1.Speed = 130;
        vehicle2.Tires = 6;

        // Print updated information using ToString method
        Console.WriteLine("\nUpdated Vehicle 1 Information:");
        Console.WriteLine(vehicle1.ToString());

        Console.WriteLine("\nUpdated Vehicle 2 Information:");
        Console.WriteLine(vehicle2.ToString());
    }
}


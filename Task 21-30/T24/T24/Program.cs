using System;
using System.Collections.Generic;

class Tire
{
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public string TireSize { get; set; }

    public Tire(string manufacturer, string model, string tireSize)
    {
        Manufacturer = manufacturer;
        Model = model;
        TireSize = tireSize;
    }

    public override string ToString()
    {
        return $"Name: {Manufacturer} Model: {Model} TireSize: {TireSize}";
    }
}

class Vehicle
{
    public string Name { get; set; }
    public string Model { get; set; }
    private List<Tire> tires;

    public Vehicle(string name, string model)
    {
        Name = name;
        Model = model;
        tires = new List<Tire>();
    }

    public void AddTire(Tire tire)
    {
        tires.Add(tire);
        Console.WriteLine($"Tire {tire.Manufacturer} added to vehicle {Name}");
    }

    public void PrintTires()
    {
        Console.WriteLine($"Vehicle Name: {Name} Model: {Model} has tires:");
        foreach (var tire in tires)
        {
            Console.WriteLine($"-{tire}");
        }
    }
}

class Program
{
    static void Main()
    {
        Vehicle porsche = new Vehicle("Porsche", "911");
        porsche.AddTire(new Tire("Nokia", "Hakkapeliitta", "205R16"));
        porsche.AddTire(new Tire("Nokia", "Hakkapeliitta", "205R16"));
        porsche.AddTire(new Tire("Nokia", "Hakkapeliitta", "205R16"));
        porsche.AddTire(new Tire("Nokia", "Hakkapeliitta", "205R16"));

        porsche.PrintTires();

        Vehicle ducati = new Vehicle("Ducati", "Diavel");
        ducati.AddTire(new Tire("MIC", "Pilot", "160R17"));
        ducati.AddTire(new Tire("MIC", "Pilot", "140R16"));

        ducati.PrintTires();
    }
}

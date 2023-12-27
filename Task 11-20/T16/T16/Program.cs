using System;

class Vehicle
{
    public string Name { get; set; }
    public string Model { get; set; }
    public int ModelYear { get; set; }
    public string Color { get; set; }

    public Vehicle(string name, string model, int modelYear, string color)
    {
        Name = name;
        Model = model;
        ModelYear = modelYear;
        Color = color;
    }

    public override string ToString()
    {
        return $"- Name: {Name} Model: {Model} ModelYear: {ModelYear} Color: {Color}";
    }
}

class Bicycle : Vehicle
{
    public bool GearWheels { get; set; }
    public string GearName { get; set; }

    public Bicycle(string name, string model, int modelYear, string color, bool gearWheels, string gearName)
        : base(name, model, modelYear, color)
    {
        GearWheels = gearWheels;
        GearName = gearName;
    }

    public override string ToString()
    {
        return $"{base.ToString()} GearWheels: {GearWheels} Gear Name: {GearName}";
    }
}

class Boat : Vehicle
{
    public int SeatCount { get; set; }
    public string BoatType { get; set; }

    public Boat(string name, string model, int modelYear, string color, int seatCount, string boatType)
        : base(name, model, modelYear, color)
    {
        SeatCount = seatCount;
        BoatType = boatType;
    }

    public override string ToString()
    {
        return $"{base.ToString()} SeatCount: {SeatCount} BoatType: {BoatType}";
    }
}

class Program
{
    static void Main()
    {
        Bicycle bike1 = new Bicycle("Jopo", "Street", 2016, "Blue", false, "");
        Bicycle bike2 = new Bicycle("Tunturi", "StreetPower", 2010, "Black", true, "Shimano Nexus");
        Boat boat1 = new Boat("SummerFun", "S900", 1990, "White", 3, "Rowboat");
        Boat boat2 = new Boat("Yamaha", "Model 1000", 2010, "Yellow", 5, "Motorboat");

        Console.WriteLine("Bike1 info");
        Console.WriteLine(bike1);
        Console.WriteLine();

        Console.WriteLine("Bike2 info");
        Console.WriteLine(bike2);
        Console.WriteLine();

        Console.WriteLine("Boat1 info");
        Console.WriteLine(boat1);
        Console.WriteLine();

        Console.WriteLine("Boat2 info");
        Console.WriteLine(boat2);
    }
}

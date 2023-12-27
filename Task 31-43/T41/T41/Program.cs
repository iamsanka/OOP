using System;
using System.Collections.Generic;
using System.Linq;

class Fish
{
    public string Species { get; set; }
    public int Length { get; set; }
    public double Weight { get; set; }
    public string Place { get; set; }
    public string Location { get; set; }

    public override string ToString()
    {
        return $"{Species} {Length} cm {Weight} kg\n - place: {Place}\n - location: {Location}";
    }
}

class Fisherman
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public List<Fish> FishList { get; set; } = new List<Fish>();

    public void CatchFish(string species, int length, double weight, string place, string location)
    {
        Fish fish = new Fish
        {
            Species = species,
            Length = length,
            Weight = weight,
            Place = place,
            Location = location
        };

        FishList.Add(fish);
    }

    public void PrintFish()
    {
        Console.WriteLine($"Fisherman: {Name} Phone: {PhoneNumber}\n");

        foreach (var fish in FishList)
        {
            Console.WriteLine(fish.ToString() + "\n");
        }
    }

    public double GetTotalWeight()
    {
        return FishList.Sum(fish => fish.Weight);
    }
}

class FishRegister
{
    private List<Fisherman> fishermen = new List<Fisherman>();

    public void AddFisherman(string name, string phoneNumber)
    {
        Fisherman fisherman = new Fisherman
        {
            Name = name,
            PhoneNumber = phoneNumber
        };

        fishermen.Add(fisherman);
        Console.WriteLine($"A new Fisherman added to Fish-register:\n - Fisherman: {name} Phone: {phoneNumber}\n");
    }

    public void AddFish(string name, string species, int length, double weight, string place, string location)
    {
        Fisherman fisherman = fishermen.FirstOrDefault(f => f.Name == name);

        if (fisherman != null)
        {
            fisherman.CatchFish(species, length, weight, place, location);
            Console.WriteLine($"Fisher : {name} got a new fish\n - {species} {length} cm {weight} kg\n - place: {place}\n - location: {location}\n");
        }
        else
        {
            Console.WriteLine($"Fisher with the name {name} not found.\n");
        }
    }

    public void PrintAllFish()
    {
        Console.WriteLine("All fish in register:\n");

        foreach (var fisherman in fishermen)
        {
            fisherman.PrintFish();
        }
    }

    public void PrintSortedRegister()
    {
        var sortedFish = fishermen
            .SelectMany(f => f.FishList.Select(fish => new { Fish = fish, Fisherman = f }))
            .OrderByDescending(item => item.Fish.Weight);

        Console.WriteLine("Sorted register\n");
        Console.WriteLine("*** All fish in Fish-register: ***\n");

        foreach (var item in sortedFish)
        {
            Console.WriteLine(item.Fish.ToString());
            Console.WriteLine($" - Fisherman: {item.Fisherman.Name}\n");
        }
    }
}

class MyFishApp
{
    static void Main(string[] args)
    {
        FishRegister fishRegister = new FishRegister();

        fishRegister.AddFisherman("Kirsi Kernel", "020-12345678");
        fishRegister.AddFisherman("Uolevi Kärppä", "050-98765432");

        fishRegister.AddFish("Kirsi Kernel", "pike", 120, 4.5, "The Lake of Jyväskylä", "Jyväskylä");
        fishRegister.AddFish("Kirsi Kernel", "salmon", 190, 13.2, "River Teno", "The Northern edge of Finland");
        fishRegister.AddFish("Uolevi Kärppä", "Crucian carp", 20, 0.4, "The Lake of Jyväskylä", "Jyväskylä");

        fishRegister.PrintAllFish();
        Console.WriteLine("Press enter key to continue...\n");
        Console.ReadLine();

        fishRegister.PrintSortedRegister();
        Console.WriteLine("Press enter key to continue...\n");
        Console.ReadLine();
    }
}

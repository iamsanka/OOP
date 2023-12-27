using System;
using System.Collections.Generic;

class FoodItem
{
    public string Name { get; set; }
    public DateTime ExpiryDate { get; set; }

    public FoodItem(string name, DateTime expiryDate)
    {
        Name = name;
        ExpiryDate = expiryDate;
    }

    public override string ToString()
    {
        return $"{Name} (Expires on: {ExpiryDate.ToShortDateString()})";
    }
}

class Refrigerator
{
    public List<FoodItem> Contents { get; }

    public Refrigerator()
    {
        Contents = new List<FoodItem>();
    }

    public void AddFood(FoodItem food)
    {
        Contents.Add(food);
    }

    public void RemoveFood(FoodItem food)
    {
        Contents.Remove(food);
    }

    public void ListContents()
    {
        Console.WriteLine("Refrigerator Contents:");
        foreach (var item in Contents)
        {
            Console.WriteLine(item);
        }
    }
}

class Program
{
    static void Main()
    {
        Refrigerator refrigerator = new Refrigerator();

        // Adding food items to the refrigerator
        FoodItem milk = new FoodItem("Milk", DateTime.Parse("2023-10-20"));
        FoodItem eggs = new FoodItem("Eggs", DateTime.Parse("2023-10-15"));
        FoodItem cheese = new FoodItem("Cheese", DateTime.Parse("2023-11-05"));

        refrigerator.AddFood(milk);
        refrigerator.AddFood(eggs);
        refrigerator.AddFood(cheese);

        // Listing refrigerator contents
        refrigerator.ListContents();

        // Removing an item
        refrigerator.RemoveFood(eggs);

        Console.WriteLine("\nAfter removing eggs:");
        refrigerator.ListContents();
    }
}

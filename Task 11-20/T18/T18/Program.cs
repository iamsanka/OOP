using System;

class Item
{
    public string Name { get; set; }
    public int Year { get; set; }

    public Item(string name, int year)
    {
        Name = name;
        Year = year;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Year: {Year}";
    }
}

class Book : Item
{
    public string Author { get; set; }
    public string Genre { get; set; }

    public Book(string name, int year, string author, string genre)
        : base(name, year)
    {
        Author = author;
        Genre = genre;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Author: {Author}, Genre: {Genre}";
    }
}

class Magazine : Item
{
    public Magazine(string name, int year)
        : base(name, year)
    {
    }
}

class Device : Item
{
    public string Brand { get; set; }
    public string Model { get; set; }

    public Device(string name, int year, string brand, string model)
        : base(name, year)
    {
        Brand = brand;
        Model = model;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Brand: {Brand}, Model: {Model}";
    }
}

class Program
{
    static void Main()
    {
        Item item1 = new Book("Book1", 2020, "Author1", "Fiction");
        Item item2 = new Magazine("Magazine1", 2021);
        Item item3 = new Device("Phone1", 2022, "Samsung", "Galaxy S21");

        Console.WriteLine(item1);
        Console.WriteLine(item2);
        Console.WriteLine(item3);
    }
}

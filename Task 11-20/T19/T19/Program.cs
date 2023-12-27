using System;

class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void MakeSound()
    {
        Console.WriteLine($"{Name} makes a sound");
    }
}

class Mammal : Animal
{
    public string FurColor { get; set; }

    public Mammal(string name, int age, string furColor)
        : base(name, age)
    {
        FurColor = furColor;
    }
}

class Bird : Animal
{
    public double Wingspan { get; set; }

    public Bird(string name, int age, double wingspan)
        : base(name, age)
    {
        Wingspan = wingspan;
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} is flying with a wingspan of {Wingspan} meters.");
    }
}

class Program
{
    static void Main()
    {
        Animal lion = new Mammal("Lion", 5, "Yellow");
        Animal eagle = new Bird("Eagle", 3, 2.2);

        lion.MakeSound();
        Console.WriteLine($"Lion's Fur Color: {((Mammal)lion).FurColor}");

        eagle.MakeSound();
        ((Bird)eagle).Fly();
    }
}

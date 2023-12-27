using System;

abstract class Mammal
{
    public int Age { get; set; }

    public Mammal(int age)
    {
        Age = age;
    }

    public abstract void Move();
}

class Human : Mammal
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }

    public Human(string name, int age, double weight, double height)
        : base(age)
    {
        Name = name;
        Weight = weight;
        Height = height;
    }

    public override void Move()
    {
        Console.WriteLine("Moving");
    }

    public void Grow()
    {
        Age++;
    }
}

class Baby : Human
{
    public string Diaper { get; set; }

    public Baby(string name, int age, double weight, double height, string diaper)
        : base(name, age, weight, height)
    {
        Diaper = diaper;
    }

    public override void Move()
    {
        Console.WriteLine("Crawling");
    }
}

class Adult : Human
{
    public string Auto { get; set; }

    public Adult(string name, int age, double weight, double height, string auto)
        : base(name, age, weight, height)
    {
        Auto = auto;
    }

    public override void Move()
    {
        Console.WriteLine("Walking");
    }
}

class Program
{
    static void Main()
    {
        Baby baby = new Baby("Baby John", 1, 10, 0.7, "Pampers");
        Adult adult = new Adult("Adult Jane", 30, 70, 1.75, "Sedan");

        baby.Move();
        baby.Grow();
        Console.WriteLine($"Baby Info:\nName: {baby.Name}\nAge: {baby.Age}\nWeight: {baby.Weight} kg\nHeight: {baby.Height} m\nDiaper: {baby.Diaper}\n");

        adult.Move();
        Console.WriteLine($"Adult Info:\nName: {adult.Name}\nAge: {adult.Age}\nWeight: {adult.Weight} kg\nHeight: {adult.Height} m\nAuto: {adult.Auto}\n");
    }
}

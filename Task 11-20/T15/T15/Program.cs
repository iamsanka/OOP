using System;

class Employee
{
    public string Name { get; set; }
    public string Profession { get; set; }
    public double Salary { get; set; }

    public Employee(string name, string profession, double salary)
    {
        Name = name;
        Profession = profession;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"Employee:\n- Name: {Name}\n- Profession: {Profession}\n- Salary: {Salary}";
    }
}

class Boss : Employee
{
    public string Car { get; set; }
    public double Bonus { get; set; }

    public Boss(string name, string profession, double salary, string car, double bonus)
        : base(name, profession, salary)
    {
        Car = car;
        Bonus = bonus;
    }

    public override string ToString()
    {
        return $"{base.ToString()}\n- Car: {Car}\n- Bonus: {Bonus}";
    }
}

class Program
{
    static void Main()
    {
        Employee employee1 = new Employee("Kirsi Kernel", "Teacher", 1200);
        Boss boss = new Boss("Hanna Husso", "Head of Institute", 9000, "Audi", 5000);
        Employee employee2 = new Employee("Kirsi Kernel", "Principal Teacher", 2200);

        Console.WriteLine(employee1);
        Console.WriteLine();
        Console.WriteLine(boss);
        Console.WriteLine();
        Console.WriteLine(employee2);
    }
}

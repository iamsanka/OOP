using System;
using System.Collections.Generic;
using System.Linq;

struct Person
{
    public string Name { get; set; }
    public int YearOfBirth { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();

        // Input loop to collect names and years of birth
        while (true)
        {
            Console.Write("Give a name (or press Enter to finish): ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                break;

            string[] parts = input.Split(',');
            if (parts.Length == 2)
            {
                string name = parts[0].Trim();
                if (int.TryParse(parts[1].Trim(), out int yearOfBirth))
                {
                    Person person = new Person { Name = name, YearOfBirth = yearOfBirth };
                    people.Add(person);
                }
                else
                {
                    Console.WriteLine("Invalid year of birth. Please enter a valid year.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input format. Please enter a name and year of birth separated by a comma.");
            }
        }

        // Sort people by age (from youngest to oldest)
        List<Person> sortedPeople = people.OrderBy(person => person.YearOfBirth).ToList();

        // Display the number of names given
        Console.WriteLine($"{sortedPeople.Count} names are given:");

        // Display names in order of age
        foreach (var person in sortedPeople)
        {
            int age = DateTime.Now.Year - person.YearOfBirth;
            Console.WriteLine($"{person.Name} is {age} years old.");
        }

        Console.WriteLine("Press any key to quit...");
        Console.ReadKey();
    }
}

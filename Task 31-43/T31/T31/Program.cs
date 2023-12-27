using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Program
{
    static Random random = new Random();

    static string GenerateRandomName(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    static List<Person> GenerateRandomPeopleList(int count)
    {
        List<Person> peopleList = new List<Person>();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        for (int i = 0; i < count; i++)
        {
            Person person = new Person
            {
                FirstName = GenerateRandomName(4),
                LastName = GenerateRandomName(10)
            };
            peopleList.Add(person);
        }

        stopwatch.Stop();
        Console.WriteLine("List Collection:");
        Console.WriteLine($"- Adding time: {stopwatch.ElapsedMilliseconds} ms");
        Console.WriteLine($"- Persons count: {peopleList.Count}");
        Console.WriteLine($"- Random person: {GenerateRandomName(4)} {GenerateRandomName(10)}");

        return peopleList;
    }

    static void SearchPeopleInList(List<Person> peopleList, int searchCount)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        for (int i = 0; i < searchCount; i++)
        {
            string randomFirstName = GenerateRandomName(4);
            var foundPerson = peopleList.FirstOrDefault(person => person.FirstName == randomFirstName);
            if (foundPerson != null)
            {
                Console.WriteLine($"- Found person with {randomFirstName} firstname : {foundPerson.FirstName} {foundPerson.LastName}");
            }
        }

        stopwatch.Stop();
        Console.WriteLine($"- Persons tried to find: {searchCount}");
        Console.WriteLine($"- Total finding time: {stopwatch.ElapsedMilliseconds} ms");
    }

    static Dictionary<string, Person> GenerateRandomPeopleDictionary(int count)
    {
        Dictionary<string, Person> peopleDictionary = new Dictionary<string, Person>();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        for (int i = 0; i < count; i++)
        {
            string randomFirstName;
            do
            {
                randomFirstName = GenerateRandomName(4);
            } while (peopleDictionary.ContainsKey(randomFirstName));

            Person person = new Person
            {
                FirstName = randomFirstName,
                LastName = GenerateRandomName(10)
            };
            peopleDictionary.Add(person.FirstName, person);
        }

        stopwatch.Stop();
        Console.WriteLine("\nDictionary Collection:");
        Console.WriteLine($"- Adding time: {stopwatch.ElapsedMilliseconds} ms");
        Console.WriteLine($"- Persons count: {peopleDictionary.Count}");
        Console.WriteLine($"- Random person: {GenerateRandomName(4)} {GenerateRandomName(10)}");

        return peopleDictionary;
    }

    static void SearchPeopleInDictionary(Dictionary<string, Person> peopleDictionary, int searchCount)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        for (int i = 0; i < searchCount; i++)
        {
            string randomFirstName = GenerateRandomName(4);
            if (peopleDictionary.TryGetValue(randomFirstName, out var foundPerson))
            {
                Console.WriteLine($"- Found person with {randomFirstName} firstname : {foundPerson.FirstName} {foundPerson.LastName}");
            }
        }

        stopwatch.Stop();
        Console.WriteLine($"- Persons tried to find: {searchCount}");
        Console.WriteLine($"- Total finding time: {stopwatch.ElapsedMilliseconds} ms");
    }

    static void Main()
    {
        int personCount = 10000;
        int searchCount = 1000;

        List<Person> peopleList = GenerateRandomPeopleList(personCount);
        SearchPeopleInList(peopleList, searchCount);

        Dictionary<string, Person> peopleDictionary = GenerateRandomPeopleDictionary(personCount);
        SearchPeopleInDictionary(peopleDictionary, searchCount);

        Console.WriteLine("\nPress Enter key to continue...");
        Console.ReadLine();
    }
}

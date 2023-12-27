using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Friend
{
    public string Name { get; set; }
    public string Email { get; set; }
}

class MailBook
{
    private List<Friend> friends;

    public MailBook()
    {
        friends = new List<Friend>();
        LoadFriendsFromFile();
    }

    public IReadOnlyList<Friend> Friends => friends;

    private void LoadFriendsFromFile()
    {
        try
        {
            string[] lines = File.ReadAllLines("friends.csv");

            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                if (parts.Length == 2)
                {
                    string name = parts[0];
                    string email = parts[1];
                    friends.Add(new Friend { Name = name, Email = email });
                }
            }

            Console.WriteLine($"{friends.Count} names in the address book:");
            foreach (var friend in friends)
            {
                Console.WriteLine(friend.Name);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No existing friend file found.");
        }
    }

    public void SearchFriends(string searchName)
    {
        var results = friends
            .Where(friend => friend.Name.Contains(searchName, StringComparison.OrdinalIgnoreCase))
            .ToList();

        if (results.Count > 0)
        {
            Console.WriteLine($"Found {results.Count} friend(s) matching '{searchName}':");
            foreach (var result in results)
            {
                Console.WriteLine($"{result.Name} {result.Email}");
            }
        }
        else
        {
            Console.WriteLine($"No friend found matching '{searchName}'.");
        }
    }

    public void AddFriend(string name, string email)
    {
        var existingFriend = friends.FirstOrDefault(friend => friend.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (existingFriend != null)
        {
            Console.WriteLine($"Friend '{name}' already exists.");
        }
        else
        {
            friends.Add(new Friend { Name = name, Email = email });
            Console.WriteLine($"Added {name} {email} to the address book.");

            try
            {
                File.AppendAllText("friends.csv", $"{name};{email}\n");
            }
            catch (IOException)
            {
                Console.WriteLine("Error writing to the file.");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        MailBook mailBook = new MailBook();

        Console.Write("\nEnter the name or part of the name of the person you are looking for > ");
        string searchName = Console.ReadLine();

        mailBook.SearchFriends(searchName);

        Console.WriteLine("\nAdd a new friend:");
        Console.Write("Name: ");
        string newName = Console.ReadLine();
        Console.Write("Email: ");
        string newEmail = Console.ReadLine();

        mailBook.AddFriend(newName, newEmail);

        Console.WriteLine("\nProgram completed successfully. Press any key to continue...");
        Console.ReadKey();
    }
}

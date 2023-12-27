using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Player
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Position { get; set; }
    public int Number { get; set; }

    public Player(string firstName, string lastName, string position, int number)
    {
        FirstName = firstName;
        LastName = lastName;
        Position = position;
        Number = number;
    }

    public override string ToString()
    {
        return $"{FirstName};{LastName};{Position};{Number}";
    }
}

class Team
{
    public string Name { get; }
    public string Hometown { get; }
    public List<Player> Players { get; }

    public Team(string teamName)
    {
        Name = teamName;
        Hometown = GetHometown(teamName);
        Players = new List<Player>();
        InitializePlayers();
    }

    private string GetHometown(string teamName)
    {
        switch (teamName)
        {
            case "JYP":
                return "Jyväskylä";
            case "Ilves":
                return "Tampere";
            // Add more cases for other teams as needed
            default:
                return "Unknown";
        }
    }

    private void InitializePlayers()
    {
        // Add players based on the team name
        switch (Name)
        {
            case "JYP":
                Players.Add(new Player("Jarkko", "Immonen", "center", 26));
                Players.Add(new Player("Brad", "Lambert", "forward", 16));
                break;
            case "Ilves":
                Players.Add(new Player("Player4_FirstName", "Player4_LastName", "position", 4));
                Players.Add(new Player("Player5_FirstName", "Player5_LastName", "position", 5));
                break;
                // Add cases for other teams and their players
        }
    }

    public void AddPlayer(Player player)
    {
        Players.Add(player);
    }

    public void RemovePlayer(Player player)
    {
        Players.Remove(player);
    }

    public void ListPlayers()
    {
        Console.WriteLine($"Team: {Name} ({Hometown})");
        Console.WriteLine("Players:");
        foreach (var player in Players)
        {
            Console.WriteLine(player);
        }
    }

    public void SavePlayersToCsv()
    {
        string csvFileName = $"{Name}.csv";
        using (StreamWriter writer = new StreamWriter(csvFileName))
        {
            foreach (var player in Players)
            {
                writer.WriteLine(player);
            }
        }
        Console.WriteLine($"Players of {Name} have been saved to {csvFileName}.");
    }
}

class Program
{
    static void Main()
    {
        Team jyp = new Team("JYP");
        Team ilves = new Team("Ilves");

        // List players for JYP and Ilves
        jyp.ListPlayers();
        ilves.ListPlayers();

        // Save players to CSV files
        jyp.SavePlayersToCsv();
        ilves.SavePlayersToCsv();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

class Player
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string GameLocation { get; set; }
    public int Number { get; set; }

    public Player(string firstName, string lastName, string gameLocation, int number)
    {
        FirstName = firstName;
        LastName = lastName;
        GameLocation = gameLocation;
        Number = number;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}, #{Number}, Location: {GameLocation}";
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
                Players.Add(new Player("Player1_FirstName", "Player1_LastName", Hometown, 10));
                Players.Add(new Player("Player2_FirstName", "Player2_LastName", Hometown, 15));
                Players.Add(new Player("Player3_FirstName", "Player3_LastName", Hometown, 20));
                break;
            case "Ilves":
                Players.Add(new Player("Player4_FirstName", "Player4_LastName", Hometown, 5));
                Players.Add(new Player("Player5_FirstName", "Player5_LastName", Hometown, 17));
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

        // Add a new player to JYP
        Player newPlayer = new Player("NewPlayer_FirstName", "NewPlayer_LastName", jyp.Hometown, 30);
        jyp.AddPlayer(newPlayer);

        Console.WriteLine("\nAfter adding a new player to JYP:");
        jyp.ListPlayers();

        // Remove a player from Ilves
        Player playerToRemove = ilves.Players.FirstOrDefault(player => player.Number == 17);
        if (playerToRemove != null)
        {
            ilves.RemovePlayer(playerToRemove);
        }

        Console.WriteLine("\nAfter removing a player from Ilves:");
        ilves.ListPlayers();
    }
}

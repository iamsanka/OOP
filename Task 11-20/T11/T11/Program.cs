using System;
using System.Collections.Generic;
using System.Text;

class CD
{
    public string Artist { get; set; }
    public string Name { get; set; }
    public string Genre { get; set; }
    public double Price { get; set; }
    public List<(string Name, string Duration)> Songs { get; set; }

    public CD(string artist, string name, string genre, double price, List<(string, string)> songs)
    {
        Artist = artist;
        Name = name;
        Genre = genre;
        Price = price;
        Songs = songs;
    }

    public string GetAllInfo()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"- Artist: {Artist}");
        sb.AppendLine($"- Name: {Name}");
        sb.AppendLine($"- Genre: {Genre}");
        sb.AppendLine($"- Price: ${Price.ToString("F2")}");
        sb.AppendLine("Songs:");
        foreach (var song in Songs)
        {
            sb.AppendLine($"--- Name: {song.Name} - {song.Duration}");
        }
        return sb.ToString();
    }
}

class Program
{
    static void Main()
    {
        List<(string, string)> songs = new List<(string, string)>
        {
            ("Shudder Before the Beautiful", "06:29"),
            ("Weak Fantasy", "05:23"),
            ("Elan", "04:45"),
            ("Yours Is an Empty Hope", "05:34"),
            ("Our Decades in the Sun", "06:37"),
            ("My Walden", "04:38"),
            ("Endless Forms Most Beautiful", "05:07"),
            ("Edema Ruh", "05:15"),
            ("Alpenglow", "04:45"),
            ("The Eyes of Sharbat Gula", "06:03"),
            ("The Greatest Show on Earth", "24:00")
        };

        CD myCD = new CD("Nightwish", "Endless Forms Most Beautiful", "Symphonic metal", 19.9, songs);

        Console.WriteLine(myCD.GetAllInfo());
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

class Song
{
    public string Name { get; set; }
    public TimeSpan Length { get; set; }

    public Song(string name, int minutes, int seconds)
    {
        Name = name;
        Length = new TimeSpan(0, minutes, seconds);
    }

    public override string ToString()
    {
        return $"{Name}, {Length:mm\\:ss}";
    }
}

class CD
{
    public string Name { get; set; }
    public string Artist { get; set; }
    private List<Song> songs;

    public CD(string name, string artist)
    {
        Name = name;
        Artist = artist;
        songs = new List<Song>();
    }

    public void AddSong(Song song)
    {
        songs.Add(song);
    }

    public int NumberOfSongs => songs.Count;

    public TimeSpan TotalLength => songs.Aggregate(TimeSpan.Zero, (acc, song) => acc + song.Length);

    public void PrintCDInfo()
    {
        Console.WriteLine($"You have a CD:\n- name: {Name}\n- artist: {Artist}\n- total length: {TotalLength.TotalMinutes} min {TotalLength.Seconds} sec");
        Console.WriteLine($"- {NumberOfSongs} songs:");

        foreach (var song in songs)
        {
            Console.WriteLine($"  - {song}");
        }
    }
}

class Program
{
    static void Main()
    {
        CD cd = new CD("Endless Forms Most Beautiful", "Nightwish");

        cd.AddSong(new Song("Shudder Before the Beautiful", 6, 29));
        cd.AddSong(new Song("Weak Fantasy", 5, 23));
        cd.AddSong(new Song("Elan", 4, 45));
        cd.AddSong(new Song("Yours Is an Empty Hope", 5, 34));
        cd.AddSong(new Song("Our Decades in the Sun", 6, 37));
        cd.AddSong(new Song("My Walden", 4, 38));
        cd.AddSong(new Song("Endless Forms Most Beautiful", 5, 7));
        cd.AddSong(new Song("Edema Ruh", 5, 15));
        cd.AddSong(new Song("Alpenglow", 4, 45));
        cd.AddSong(new Song("The Eyes of Sharbat Gula", 6, 3));
        cd.AddSong(new Song("The Greatest Show on Earth", 24, 0));

        cd.PrintCDInfo();
    }
}

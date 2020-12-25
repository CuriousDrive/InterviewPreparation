using System;
using System.Collections.Generic;

public class Song
{
    private string name;
    public Song NextSong { get; set; }

    public Song(string name)
    {
        this.name = name;
    }

    public bool IsRepeatingPlaylist()
    {
        List<string> songsPlayed = new List<string>();
        Song currentSong = this;
        while(currentSong != null && currentSong.NextSong != null)
        {
            if(songsPlayed.Contains(currentSong.name))
            {
                return true;
            }

            songsPlayed.Add(currentSong.name);
            currentSong = currentSong.NextSong;
        }
        return false;
    }

    public static void Main(string[] args)
    {
        Song first = new Song("Hello");
        Song second = new Song("Eye of the tiger");

        first.NextSong = second;
        second.NextSong = null;

        Console.WriteLine(first.IsRepeatingPlaylist());
    }
}
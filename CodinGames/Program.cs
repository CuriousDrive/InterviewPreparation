using System;
using System.Collections.Generic;

public class Song
{
    private string name;
    public Song NextSong { get; set; }
    List<Song> PreviouSongs { get; set; } = new List<Song>();

    public Song(string name)
    {
        this.name = name;
    }

    public bool IsRepeatingPlaylist()
    {
        Song currentSong = this;
        while(currentSong.NextSong != null)
        {
            currentSong = currentSong.NextSong;
            if(currentSong == this)
            {
                return true;
            }
        }
        return false;
    }

    public static void Main2(string[] args)
    {
        Song first = new Song("Hello");
        Song second = new Song("Eye of the tiger");
        Song third = new Song("Coldplay");

        first.NextSong = second;
        second.NextSong = first;

        Console.WriteLine(first.IsRepeatingPlaylist());
    }
}
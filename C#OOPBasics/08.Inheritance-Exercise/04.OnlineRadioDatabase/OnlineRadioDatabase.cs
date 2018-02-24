using System;
using System.Collections.Generic;
using System.Linq;

public class OnlineRadioDatabase
{
    public static void Main()
    {
        var playlist = new List<Song>();

        var numberOfSongs = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfSongs; i++)
        {
            try
            {
                var inputSongs = Console.ReadLine()
                    .Split(new[] { ";", ":" }, StringSplitOptions.RemoveEmptyEntries);

                var song = new Song(inputSongs[0], inputSongs[1], int.Parse(inputSongs[2]), int.Parse(inputSongs[3]));

                playlist.Add(song);
                Console.WriteLine("Song added.");
            }
            catch (InvalidSongException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Invalid song length.");
            }
        }

        Console.WriteLine($"Songs added: {playlist.Count}");

        var totalMinutes = playlist.Sum(m => m.Minutes);
        var totalSeconds = playlist.Sum(s => s.Seconds);

        totalSeconds += totalMinutes * 60;
        var minutesResult = totalSeconds / 60;
        var secondsResult = totalSeconds % 60;
        var hoursResult = minutesResult / 60;
        minutesResult %= 60;

        Console.WriteLine($"Playlist length: {hoursResult}h {minutesResult}m {secondsResult}s");
    }
}
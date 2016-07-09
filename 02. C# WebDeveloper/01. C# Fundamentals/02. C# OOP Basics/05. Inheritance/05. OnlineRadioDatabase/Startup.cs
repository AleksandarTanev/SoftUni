namespace _05.OnlineRadioDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Exceptions;

    public class Startup
    {
        public static void Main()
        {
            var songs = new List<Song>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                string artistName = tokens[0];
                string songName = tokens[1];

                string[] time = tokens[2].Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    Song song = new Song(artistName, songName, time);
                    songs.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongLengthException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (InvalidSongException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            int totalMinutes = songs.Sum(s => s.Minutes);
            int totalSeconds = songs.Sum(s => s.Seconds);

            totalMinutes += totalSeconds / 60;
            totalSeconds = totalSeconds % 60;

            int totalHours = 0;
            totalHours += totalMinutes / 60;
            totalMinutes = totalMinutes % 60;

            Console.WriteLine($"Songs added: {songs.Count}");
            Console.WriteLine($"Playlist length: {totalHours}h {totalMinutes}m {totalSeconds}s");
        }
    }
}

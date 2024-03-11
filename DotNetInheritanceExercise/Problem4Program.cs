namespace DotNetInheritanceExercise
{
    public static class Problem4Program
    {
        public static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            int secondsAccumulated = 0;
            int songsAccumulated = 0;
            for (int i = 0; i < numberOfSongs; i++)
            {
                string songString = Console.ReadLine();
                try
                {
                    string[] songSegments = songString.Split(';');
                    if (songSegments.Length != 3)
                        throw new InvalidSongException();
                    string artistName = songSegments[0].Trim();
                    if (artistName.Length < 3 || artistName.Length > 20)
                        throw new InvalidArtistNameException();
                    string songName = songSegments[1].Trim();
                    if (songName.Length < 3 || songName.Length > 30)
                        throw new InvalidSongNameException();
                    string songLengthString = songSegments[2].Trim();
                    string[] songLengthSegments = songLengthString.Split(":");
                    if (songLengthSegments.Length != 2)
                        throw new InvalidSongLengthException();
                    int songLengthMinutes;
                    int songLengthSeconds;
                    string songLengthMinutesString = songLengthSegments[0];
                    string songLengthSecondsString = songLengthSegments[1];
                    if (!int.TryParse(songLengthMinutesString, out songLengthMinutes))
                        throw new InvalidSongLengthException();
                    if (!int.TryParse(songLengthSecondsString, out songLengthSeconds))
                        throw new InvalidSongLengthException();
                    if (songLengthMinutes < 0 || songLengthMinutes > 14)
                        throw new InvalidSongMinutesException();
                    if (songLengthSeconds < 0 || songLengthSeconds > 59)
                        throw new InvalidSongSecondsException();
                    songsAccumulated++;
                    secondsAccumulated += 60 * songLengthMinutes + songLengthSeconds;
                    Console.WriteLine("Song added.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine($"Songs added: {songsAccumulated}");
            Console.WriteLine($"Playlist length: {secondsAccumulated / 3600}h {(secondsAccumulated / 60) % 60}m {secondsAccumulated % 60}s");
        }
    }
}

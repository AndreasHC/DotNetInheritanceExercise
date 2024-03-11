namespace DotNetInheritanceExercise
{
    internal class InvalidArtistNameException : InvalidSongException
    {
        public InvalidArtistNameException() : this("Artist name should be between 3 and 20 symbols.")
        { }
        public InvalidArtistNameException(string message) : base(message)
        { }
    }
}

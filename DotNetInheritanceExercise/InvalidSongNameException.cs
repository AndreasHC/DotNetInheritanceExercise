namespace DotNetInheritanceExercise
{
    internal class InvalidSongNameException : InvalidSongException
    {
        public InvalidSongNameException() : this("Song name should be between 3 and 30 symbols.")
        { }
        public InvalidSongNameException(string message) : base(message)
        { }
    }
}

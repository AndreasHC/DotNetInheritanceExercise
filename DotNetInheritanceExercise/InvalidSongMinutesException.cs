namespace DotNetInheritanceExercise
{
    internal class InvalidSongMinutesException : InvalidSongLengthException
    {
        public InvalidSongMinutesException() : this("Song minutes should be between 0 and 14.")
        { }
        public InvalidSongMinutesException(string message) : base(message)
        { }
    }
}

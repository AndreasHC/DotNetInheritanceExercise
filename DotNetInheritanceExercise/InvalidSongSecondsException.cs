namespace DotNetInheritanceExercise
{
    internal class InvalidSongSecondsException : InvalidSongLengthException
    {
        public InvalidSongSecondsException() : this("Song seconds should be between 0 and 59.")
        { }
        public InvalidSongSecondsException(string message) : base(message)
        { }
    }
}

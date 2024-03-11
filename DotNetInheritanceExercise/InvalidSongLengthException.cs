namespace DotNetInheritanceExercise
{
    internal class InvalidSongLengthException : InvalidSongException
    {
        public InvalidSongLengthException() : this("Invalid song length.")
        { }
        public InvalidSongLengthException(string message) : base(message)
        { }
    }
}

namespace _05.OnlineRadioDatabase.Exceptions
{
    class InvalidSongLengthException : InvalidSongException
    {
        public InvalidSongLengthException(string message)
            : base(message)
        {

        }

        public InvalidSongLengthException()
            : base("Invalid song length.")
        {

        }
    }
}

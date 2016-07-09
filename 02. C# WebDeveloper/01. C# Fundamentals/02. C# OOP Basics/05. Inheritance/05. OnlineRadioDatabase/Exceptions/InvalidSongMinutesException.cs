namespace _05.OnlineRadioDatabase.Exceptions
{
    class InvalidSongMinutesException : InvalidSongLengthException
    {
        public InvalidSongMinutesException(string message)
            : base(message)
        {

        }

        public InvalidSongMinutesException()
            : base("Song minutes should be between 0 and 14.")
        {

        }
    }
}

namespace _05.OnlineRadioDatabase.Exceptions
{
    class InvalidSongSecondsException : InvalidSongLengthException
    {
        public InvalidSongSecondsException(string message)
            : base(message)
        {

        }

        public InvalidSongSecondsException()
            : base("Song seconds should be between 0 and 59.")
        {

        }
    }
}

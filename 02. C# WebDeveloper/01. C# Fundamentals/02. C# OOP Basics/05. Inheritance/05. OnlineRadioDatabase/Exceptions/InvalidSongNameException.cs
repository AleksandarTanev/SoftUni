namespace _05.OnlineRadioDatabase.Exceptions
{
    class InvalidSongNameException : InvalidSongException
    {
        public InvalidSongNameException(string message)
            : base(message)
        {

        }

        public InvalidSongNameException()
            : base("Song name should be between 3 and 30 symbols.")
        {

        }
    }
}

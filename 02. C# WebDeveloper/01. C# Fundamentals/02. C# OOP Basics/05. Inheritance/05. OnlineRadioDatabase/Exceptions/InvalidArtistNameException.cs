namespace _05.OnlineRadioDatabase.Exceptions
{
    class InvalidArtistNameException : InvalidSongException
    {
        public InvalidArtistNameException(string message)
            : base(message)
        {
            
        }

        public InvalidArtistNameException()
            : base("Artist name should be between 3 and 20 symbols.")
        {

        }
    }
}

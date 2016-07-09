namespace _05.OnlineRadioDatabase
{
    using System;

    class InvalidSongException : Exception
    {
        public InvalidSongException(string message)
            : base(message)
        {
        }

        public InvalidSongException()
            : base("Invalid song.")
        {
            
        }
    }
}

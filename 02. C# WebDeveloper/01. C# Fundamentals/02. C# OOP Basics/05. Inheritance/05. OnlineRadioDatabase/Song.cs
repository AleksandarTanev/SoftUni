namespace _05.OnlineRadioDatabase
{
    using Exceptions;

    public class Song
    {
        private string artistName;
        private string songName;
        private int minutes;
        private int seconds;

        public Song(string artistName, string songName, string[] time)
        {
            this.ArtistName = artistName;
            this.SongName = songName;

            SplitTime(time);
        }

        public string ArtistName
        {
            get
            {
                return artistName;
            }

            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException();
                }

                artistName = value;
            }
        }

        public string SongName
        {
            get
            {
                return songName;
            }

            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidSongNameException();
                }

                songName = value;
            }
        }

        public int Minutes
        {
            get
            {
                return minutes;
            }

            set
            {
                if (value < 0 || value > 14)
                {
                    throw new InvalidSongMinutesException();
                }

                minutes = value;
            }
        }

        public int Seconds
        {
            get
            {
                return seconds;
            }

            set
            {
                if (value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException();
                }

                seconds = value;
            }
        }

        private void SplitTime(string[] time)
        {
            if (time.Length != 2)
            {
                throw new InvalidSongLengthException();
            }

            int minutes;
            int seconds;

            if (!int.TryParse(time[0], out minutes) || !int.TryParse(time[1], out seconds))
            {
                throw new InvalidSongLengthException();
            }

            this.Minutes = minutes;
            this.Seconds = seconds;
        }
    }
}

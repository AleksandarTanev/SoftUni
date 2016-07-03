namespace _06.ValidatEPizza
{
    using System;

    public class Player
    {
        private string name;

        private int endurance = 0;
        private int sprint = 0;
        private int dribble = 0;
        private int passing = 0;
        private int shooting = 0;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public string Name
        {
            get
            {
                return name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                name = value;
            }
        }

        public int Endurance
        {
            get
            {
                return endurance;
            }

            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{nameof(Endurance)} should be between 0 and 100.");
                }

                endurance = value;
            }
        }

        public int Sprint
        {
            get
            {
                return sprint;
            }

            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{nameof(Sprint)} should be between 0 and 100.");
                }

                sprint = value;
            }
        }

        public int Dribble
        {
            get
            {
                return dribble;
            }

            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{nameof(Dribble)} should be between 0 and 100.");
                }

                dribble = value;
            }
        }

        public int Passing
        {
            get
            {
                return passing;
            }

            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{nameof(Passing)} should be between 0 and 100.");
                }

                passing = value;
            }
        }

        public int Shooting
        {
            get
            {
                return shooting;
            }

            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{nameof(Shooting)} should be between 0 and 100.");
                }

                shooting = value;
            }
        }

        public double GetAvrSkill()
        {
            double avr = (this.Shooting + this.Dribble + this.Endurance + this.Passing + this.Sprint) / 5.0;

            return avr;
        }
    }
}

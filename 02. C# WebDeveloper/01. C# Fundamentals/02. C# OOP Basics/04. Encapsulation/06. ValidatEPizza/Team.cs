namespace _06.ValidatEPizza
{
    using System;
    using System.Collections.Generic;

    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.name = name;
            this.players = new List<Player>();
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                name = value;
            }
        }

        public double GetRating()
        {
            if (players.Count == 0)
            {
                return 0;
            }

            double rating = 0;

            foreach (var player in this.players)
            {
                rating += player.GetAvrSkill();
            }

            return rating / players.Count;
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string name)
        {
            int index = -1;
            for (int i = 0; i < this.players.Count; i++)
            {
                if (players[i].Name == name)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                this.players.RemoveAt(index);
            }
            else
            {
                Console.WriteLine($"Player {name} is not in {this.name} team.");
            }
        }

        public override string ToString()
        {
            return $"{this.Name} - {Math.Round(this.GetRating())}";
        }
    }
}

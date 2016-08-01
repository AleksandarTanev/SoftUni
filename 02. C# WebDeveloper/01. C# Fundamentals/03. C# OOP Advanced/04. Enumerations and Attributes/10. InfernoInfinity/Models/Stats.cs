namespace _10.InfernoInfinity.Models
{
    using Interfaces;

    public class Stats : IStats
    {
        public Stats()
        {
            this.Strength = 0;
            this.Agility = 0;
            this.Vitality = 0;
        }

        public Stats(int strength, int agility, int vitality)
        {
            this.Strength = strength;
            this.Agility = agility;
            this.Vitality = vitality;
        }

        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Vitality { get; set; }
    }
}

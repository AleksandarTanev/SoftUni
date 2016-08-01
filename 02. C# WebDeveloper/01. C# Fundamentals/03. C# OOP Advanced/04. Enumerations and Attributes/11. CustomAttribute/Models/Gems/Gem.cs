namespace _11.CustomAttribute.Models.Gems
{
    using Enums;
    using Interfaces;

    public abstract class Gem : IGem
    {
        protected Gem(IStats originalStats, GemQuality quality)
        {
            this.Quality = quality;

            this.OriginalStats = originalStats;
        }

        public IStats OriginalStats { get; }
        public GemQuality Quality { get; }

        public IStats GetTotalStats()
        {
            IStats totalStats = new Stats();

            totalStats.Strength = this.OriginalStats.Strength + (int) this.Quality;
            totalStats.Agility = this.OriginalStats.Agility + (int) this.Quality;
            totalStats.Vitality = this.OriginalStats.Vitality + (int) this.Quality;

            return totalStats;
        }
    }
}

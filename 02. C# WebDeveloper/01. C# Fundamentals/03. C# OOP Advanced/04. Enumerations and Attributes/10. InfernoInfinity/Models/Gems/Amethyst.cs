namespace _10.InfernoInfinity.Models.Gems
{
    using Enums;

    public class Amethyst : Gem
    {
        private const int Strength = 2;
        private const int Agility = 8;
        private const int Vitality = 4;

        public Amethyst(GemQuality quality)
            : base(new Stats(Strength, Agility, Vitality), quality)
        {
        }
    }
}

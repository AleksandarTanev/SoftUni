namespace _10.InfernoInfinity.Models.Gems
{
    using Enums;

    public class Ruby : Gem
    {
        private const int Strength = 7;
        private const int Agility = 2;
        private const int Vitality = 5;

        public Ruby(GemQuality quality) 
            : base(new Stats(Strength, Agility, Vitality), quality)
        {
        }
    }
}

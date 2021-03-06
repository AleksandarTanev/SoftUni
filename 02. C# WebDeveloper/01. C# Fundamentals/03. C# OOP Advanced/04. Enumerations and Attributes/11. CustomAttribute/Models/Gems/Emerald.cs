﻿namespace _11.CustomAttribute.Models.Gems
{
    using Enums;

    public class Emerald : Gem
    {
        private const int Strength = 1;
        private const int Agility = 4;
        private const int Vitality = 9;

        public Emerald(GemQuality quality)
            : base(new Stats(Strength, Agility, Vitality), quality)
        {
        }
    }
}

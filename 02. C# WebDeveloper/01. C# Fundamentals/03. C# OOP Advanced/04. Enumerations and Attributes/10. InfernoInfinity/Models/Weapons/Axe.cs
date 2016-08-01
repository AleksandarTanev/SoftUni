namespace _10.InfernoInfinity.Models.Weapons
{
    using Enums;

    class Axe : Weapon
    {
        private const int OriginalMinDamage = 5;
        private const int OriginalMaxDamage = 10;
        private const int SocketNumber = 4;

        public Axe(string name, WeaponRarity rarity) 
            : base(name, OriginalMinDamage, OriginalMaxDamage, rarity, SocketNumber)
        {
        }
    }
}

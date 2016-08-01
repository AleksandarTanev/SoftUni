namespace _10.InfernoInfinity.Models.Weapons
{
    using Enums;

    class Sword : Weapon
    {
        private const int OriginalMinDamage = 4;
        private const int OriginalMaxDamage = 6;
        private const int SocketNumber = 3;

        public Sword(string name, WeaponRarity rarity)
            : base(name, OriginalMinDamage, OriginalMaxDamage, rarity, SocketNumber)
        {
        }
    }
}

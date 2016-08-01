namespace _10.InfernoInfinity.Models.Weapons
{
    using Enums;

    class Knife : Weapon
    {
        private const int OriginalMinDamage = 3;
        private const int OriginalMaxDamage = 4;
        private const int SocketNumber = 2;

        public Knife(string name, WeaponRarity rarity)
            : base(name, OriginalMinDamage, OriginalMaxDamage, rarity, SocketNumber)
        {

        }
    }
}

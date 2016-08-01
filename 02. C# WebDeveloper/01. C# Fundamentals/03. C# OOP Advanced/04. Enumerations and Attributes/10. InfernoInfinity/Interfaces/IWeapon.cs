namespace _10.InfernoInfinity.Interfaces
{
    using Enums;

    public interface IWeapon
    {
        string Name { get; }

        int MinDamage { get; }
        int MaxDamage { get; }

        WeaponRarity Rarity { get; }

        int NumOfSockets { get; }
        void AddGem(IGem gem, int index);
        void RemoveGem(int index);

        int GetMinDamageDone();
        int GetMaxDamageDone();

        IStats GetTotalStats();
    }
}

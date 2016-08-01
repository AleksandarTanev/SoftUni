namespace _11.CustomAttribute.Models.Weapons
{
    using System.Linq;

    using Enums;
    using Interfaces;
    using Attributes;

    [Info(Author = "Pesho", Revisions = 3, Description = "Used for C# OOP Advanced Course - Enumerations and Attributes.", Reviewers = new[] { "Pesho", "Svetlio" })]
    public abstract class Weapon : IWeapon
    {
        private IGem[] sockets;

        protected Weapon(string name, int minDamage, int maxDamage, WeaponRarity rarity, int sockets)
        {
            this.Name = name;

            this.MinDamage = minDamage;
            this.MaxDamage = maxDamage;

            this.Rarity = rarity;
            this.NumOfSockets = sockets;

            this.sockets = new IGem[this.NumOfSockets];
        }

        public string Name { get; }

        public int MinDamage { get; }
        public int MaxDamage { get; }

        public WeaponRarity Rarity { get; }

        public int NumOfSockets { get; }

        public IStats GetTotalStats()
        {
            IStats totalStats = new Stats();

            totalStats.Strength = this.sockets
                .Where(s => s != null)
                .Sum(s => s.GetTotalStats().Strength);

            totalStats.Agility = this.sockets
                .Where(s => s != null)
                .Sum(s => s.GetTotalStats().Agility);

            totalStats.Vitality = this.sockets
                .Where(s => s != null)
                .Sum(s => s.GetTotalStats().Vitality);

            return totalStats;
        }

        public void AddGem(IGem gem, int index)
        {
            if (index < 0 || index >= this.NumOfSockets)
            {
                return;
            }

            this.sockets[index] = gem;
        }

        public void RemoveGem(int index)
        {
            if (index < 0 || index >= this.NumOfSockets)
            {
                return;
            }

            this.sockets[index] = null;
        }

        public virtual int GetMinDamageDone()
        {
            int output = this.MinDamage * (int) Rarity;
            output += this.GetTotalStats().Strength * 2;
            output += this.GetTotalStats().Agility * 1;

            return output;
        }

        public virtual int GetMaxDamageDone()
        {
            int output = this.MaxDamage * (int)Rarity;
            output += this.GetTotalStats().Strength * 3;
            output += this.GetTotalStats().Agility * 4;

            return output;
        }

        public override string ToString()
        {
            return $"{this.Name}: {this.GetMinDamageDone()}-{this.GetMaxDamageDone()} Damage, +{this.GetTotalStats().Strength} Strength, +{this.GetTotalStats().Agility} Agility, +{this.GetTotalStats().Vitality} Vitality";
        }
    }
}

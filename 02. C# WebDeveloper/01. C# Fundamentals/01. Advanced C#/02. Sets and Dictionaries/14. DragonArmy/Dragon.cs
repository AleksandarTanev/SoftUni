namespace _14.DragonArmy
{
    public class Dragon
    {
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }

        public Dragon(int damage, int health, int armor)
        {
            this.Damage = damage;
            this.Health = health;
            this.Armor = armor;
        }
    }
}

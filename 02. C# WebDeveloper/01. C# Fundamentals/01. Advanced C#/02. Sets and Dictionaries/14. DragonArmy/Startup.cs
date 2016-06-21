namespace _14.DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        static void Main()
        {
            var dragons = new Dictionary<string, SortedDictionary<string, Dragon>>();

            int numOfInputes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfInputes; i++)
            {
                var splittedInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string type = splittedInput[0];
                string name = splittedInput[1];
                int damage = 45;
                int health = 250;
                int armor = 10;

                if (splittedInput[2] != "null")
                {
                    damage = int.Parse(splittedInput[2]);
                }

                if (splittedInput[3] != "null")
                {
                    health = int.Parse(splittedInput[3]);
                }

                if (splittedInput[4] != "null")
                {
                    armor = int.Parse(splittedInput[4]);
                }


                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new SortedDictionary<string, Dragon>();
                }

                dragons[type][name] = new Dragon(damage, health, armor);
            }

            foreach (var type in dragons)
            {
                double avrDamage = dragons[type.Key].Sum(x => x.Value.Damage) / (double) dragons[type.Key].Count;
                double avrHealth = dragons[type.Key].Sum(x => x.Value.Health) / (double) dragons[type.Key].Count;
                double avrArmor = dragons[type.Key].Sum(x => x.Value.Armor) / (double) dragons[type.Key].Count;

                Console.WriteLine("{0}::({1:F2}/{2:F2}/{3:F2})", type.Key, avrDamage, avrHealth, avrArmor);

                foreach (var dragon in type.Value)
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value.Damage}, health: {dragon.Value.Health}, armor: {dragon.Value.Armor}");
                }
            }
        }
    }
}

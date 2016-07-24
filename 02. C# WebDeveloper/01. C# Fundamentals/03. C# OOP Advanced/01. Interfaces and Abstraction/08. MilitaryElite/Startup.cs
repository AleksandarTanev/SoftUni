namespace _08.MilitaryElite
{
    using System.Collections.Generic;
    using System;
    using System.ComponentModel;

    using Interfaces;
    using Factories;

    public class Startup
    {
        public static void Main()
        {
            var soldiers = new HashSet<ISoldier>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                var tokens = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    var soldier = SoldierFactory.GenerateSoldier(tokens);
                    if (soldier != null)
                    {
                        soldiers.Add(soldier);
                    }
                }
                catch (InvalidEnumArgumentException)
                {
                    
                }

                input = Console.ReadLine();
            }

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }
        }
    }
}

namespace _02.KingsGambit
{
    using System;
    using System.Collections.Generic;

    using Interfaces;
    using Models;

    public class Startup
    {
        public static void Main()
        {
            var soldiers = new Dictionary<string, IKillable>();

            var kingName = Console.ReadLine();
            var king = new King(kingName);

            var namesOfSoldiers = Console.ReadLine().Split();
            foreach (var namesOfSoldier in namesOfSoldiers)
            {
                soldiers.Add(namesOfSoldier, new RoyalGuard(namesOfSoldier, king));
            }

            namesOfSoldiers = Console.ReadLine().Split();
            foreach (var namesOfSoldier in namesOfSoldiers)
            {
                soldiers.Add(namesOfSoldier, new Footman(namesOfSoldier, king));
            }

            var input = Console.ReadLine();
            while (input != "End")
            {
                var tokens = input.Split();

                string command = tokens[0];
                string givenName = tokens[1];

                if (command == "Kill")
                {
                    soldiers[givenName].Kill();
                }
                else if (command == "Attack")
                {
                    king.Attacked();
                }

                input = Console.ReadLine();
            }
        }
    }
}

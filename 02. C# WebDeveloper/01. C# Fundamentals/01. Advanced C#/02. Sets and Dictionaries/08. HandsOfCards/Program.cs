namespace _08.HandsOfCards
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var players = new Dictionary<string, HashSet<string>>();

            string input = Console.ReadLine();
            while (input != "JOKER")
            {
                var pair = input.Split(new char[] {':'}, StringSplitOptions.RemoveEmptyEntries);

                if (!players.ContainsKey(pair[0]))
                {
                    players[pair[0]] = new HashSet<string>();
                }

                var cards = pair[1].Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

                foreach (var card in cards)
                {
                    players[pair[0]].Add(card);
                }

                input = Console.ReadLine();
            }

            foreach (var player in players)
            {
                int power = 0;

                foreach (var card in player.Value)
                {
                    Card realCard = new Card(card);
                    power += realCard.CardPower;
                }

                Console.WriteLine($"{player.Key}: {power}");
            }


        }
    }
}

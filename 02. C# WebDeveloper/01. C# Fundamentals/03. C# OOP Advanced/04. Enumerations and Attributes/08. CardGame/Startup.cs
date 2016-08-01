namespace _08.CardGame
{
    using System;
    using System.Collections.Generic;

    using Enums;
    using Models;

    public class Startup
    {
        private static HashSet<string> usedCards = new HashSet<string>(); 

        public static void Main()
        {
            var firstPlayer = new Player(Console.ReadLine());
            var secondPlayer = new Player(Console.ReadLine());

            FillPlayerHand(firstPlayer);
            FillPlayerHand(secondPlayer);

            if (firstPlayer.GetStrongestCard.Power > secondPlayer.GetStrongestCard.Power)
            {
                Console.WriteLine($"{firstPlayer.Name} wins with {firstPlayer.GetStrongestCard}.");
            }
            else
            {
                Console.WriteLine($"{secondPlayer.Name} wins with {secondPlayer.GetStrongestCard}.");
            }
        }

        private static void FillPlayerHand(Player player)
        {
            while (player.CardCount < 5)
            {
                var tokens = Console.ReadLine().Split(new string[] { " of " }, StringSplitOptions.RemoveEmptyEntries);
                string rank = tokens[0];
                string suit = tokens[1];

                try
                {
                    CardRank givenRank = (CardRank)Enum.Parse(typeof(CardRank), rank);
                    CardSuit givenSuit = (CardSuit)Enum.Parse(typeof(CardSuit), suit);

                    var givenCard = new Card(givenSuit, givenRank);

                    if (usedCards.Contains(givenCard.ToString()))
                    {
                        Console.WriteLine("Card is not in the deck.");
                        continue;
                    }

                    usedCards.Add(givenCard.ToString());
                    player.AddCard(givenCard);
                }
                catch (Exception)
                {
                    Console.WriteLine("No such card exists.");
                }
            }
        }
    }
}

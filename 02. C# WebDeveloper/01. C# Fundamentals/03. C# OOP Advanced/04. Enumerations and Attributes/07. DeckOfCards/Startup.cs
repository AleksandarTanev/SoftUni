namespace _07.DeckOfCards
{
    using System;
    using Enums;

    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var allCardSuits = Enum.GetValues(typeof (CardSuit));
            var allCardRanks = Enum.GetValues(typeof (CardRank));

            foreach (var cardSuit in allCardSuits)
            {
                foreach (var cardRank in allCardRanks)
                {
                    Console.WriteLine($"{cardRank} of {cardSuit}");
                }
            }
        }
    }
}

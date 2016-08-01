namespace _02.CardRank
{
    using System;
    using System.Linq;

    using Enums;

    public class Startup
    {
        public static void Main()
        {
            var cards = Enum.GetValues(typeof(CardRank)).Cast<CardRank>();

            Console.WriteLine("Card Ranks:");
            foreach (var card in cards)
            {
                Console.WriteLine($"Ordinal value: {(int)card}; Name value: {card}");
            }
        }
    }
}

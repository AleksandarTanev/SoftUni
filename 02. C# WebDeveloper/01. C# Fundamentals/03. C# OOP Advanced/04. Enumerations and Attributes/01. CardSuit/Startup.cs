namespace _01.CardSuit
{
    using System;
    using System.Linq;

    using Enums;

    public class Startup
    {
        public static void Main()
        {
            var cards = Enum.GetValues(typeof(CardSuit)).Cast<CardSuit>();

            Console.WriteLine("Card Suits:");
            foreach (var card in cards)
            {
                Console.WriteLine($"Ordinal value: {(int)card}; Name value: {card}");
            }
        }
    }
}

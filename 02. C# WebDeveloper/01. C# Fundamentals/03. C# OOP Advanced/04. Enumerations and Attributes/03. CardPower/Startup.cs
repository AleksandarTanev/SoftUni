namespace _03.CardPower
{
    using System;

    using Enums;
    using Models;

    public class Startup
    {
        public static void Main()
        {
            CardRank rank = (CardRank) Enum.Parse(typeof(CardRank), Console.ReadLine());
            CardSuit suit = (CardSuit) Enum.Parse(typeof(CardSuit), Console.ReadLine());

            var card = new Card(suit, rank);

            Console.WriteLine(card);
        }
    }
}

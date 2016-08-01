namespace _05.CardCompareTo
{
    using System;

    using Enums;
    using Models;

    public class Startup
    {
        public static void Main()
        {
            CardRank rank = (CardRank)Enum.Parse(typeof(CardRank), Console.ReadLine());
            CardSuit suit = (CardSuit)Enum.Parse(typeof(CardSuit), Console.ReadLine());

            var firstCard = new Card(suit, rank);

            rank = (CardRank)Enum.Parse(typeof(CardRank), Console.ReadLine());
            suit = (CardSuit)Enum.Parse(typeof(CardSuit), Console.ReadLine());

            var secondCard = new Card(suit, rank);

            if (firstCard.CompareTo(secondCard) >= 0)
            {
                Console.WriteLine(firstCard);
            }
            else
            {
                Console.WriteLine(secondCard);
            }
        }
    }
}

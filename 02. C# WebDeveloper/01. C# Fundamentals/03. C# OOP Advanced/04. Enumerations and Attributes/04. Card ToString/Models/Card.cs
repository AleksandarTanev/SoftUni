namespace _04.Card_ToString.Models
{
    using Enums;

    public class Card
    {
        public Card(CardSuit suit, CardRank rank)
        {
            this.Suit = suit;
            this.Rank = rank;
        }

        public CardSuit Suit { get; private set; }
        public CardRank Rank { get; private set; }

        public int Power => (int) this.Suit + (int) this.Rank;

        public override string ToString()
        {
            return $"Card name: {this.Rank} of {this.Suit}; Card power: {this.Power}";
        }
    }
}

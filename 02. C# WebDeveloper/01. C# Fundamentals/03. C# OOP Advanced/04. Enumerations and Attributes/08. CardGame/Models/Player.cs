namespace _08.CardGame.Models
{
    using System.Collections.Generic;
    using System.Linq;

    public class Player
    {
        private HashSet<Card> hand;

        public Player(string name)
        {
            Name = name;
            this.hand = new HashSet<Card>();
        }

        public string Name { get; set; }

        public Card GetStrongestCard => this.hand.FirstOrDefault(c => c.Power == this.hand.Max(p => p.Power));

        public int CardCount => this.hand.Count;

        public void AddCard(Card newCard)
        {
            this.hand.Add(newCard);
        }
    }
}

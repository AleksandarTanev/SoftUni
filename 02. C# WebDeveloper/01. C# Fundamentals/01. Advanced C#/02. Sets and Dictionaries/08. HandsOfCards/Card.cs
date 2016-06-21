namespace _08.HandsOfCards
{
    public class Card
    {
        public string Power { get; set; }
        public string Type { get; set; }
        public int CardPower { get; set; }


        public Card(string card)
        {
            this.Power = card.Substring(0, card.Length - 1);
            this.Type = card.Substring(card.Length - 1);

            CalculateCardPower();
        }

        private void CalculateCardPower()
        {
            int powerOfPower = 0;
            int powerOfType = 0;

            if (Type == "S")
            {
                powerOfType = 4;
            }
            else if (Type == "H")
            {
                powerOfType = 3;
            }
            else if (Type == "D")
            {
                powerOfType = 2;
            }
            else if (Type == "C")
            {
                powerOfType = 1;
            }

            if (Power == "J")
            {
                powerOfPower = 11;
            }
            else if (Power == "Q")
            {
                powerOfPower = 12;
            }
            else if (Power == "K")
            {
                powerOfPower = 13;
            }
            else if (Power == "A")
            {
                powerOfPower = 14;
            }
            else
            {
                powerOfPower = int.Parse(Power);
            }

            CardPower = powerOfPower*powerOfType;
        }
    }
}

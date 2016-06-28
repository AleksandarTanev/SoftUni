namespace _11.CatLady
{
    public class StreetExtraordinaire : Cat
    {
        public int decibelsOfMeows;

        public StreetExtraordinaire(string name, int decibelsOfMeows)
            : base(name)
        {
            this.decibelsOfMeows = decibelsOfMeows;
        }

        public override string ToString()
        {
            string result = $"StreetExtraordinaire {this.name} {this.decibelsOfMeows}";

            return result;
        }
    }
}

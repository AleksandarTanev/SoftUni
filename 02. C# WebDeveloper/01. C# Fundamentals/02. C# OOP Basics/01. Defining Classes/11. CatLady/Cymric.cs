namespace _11.CatLady
{
    public class Cymric : Cat
    {
        public double furLength;

        public Cymric(string name, double furLength)
            : base(name)
        {
            this.furLength = furLength;
        }

        public override string ToString()
        {
            string result = $"Cymric {this.name} {this.furLength:F2}";

            return result;
        }
    }
}

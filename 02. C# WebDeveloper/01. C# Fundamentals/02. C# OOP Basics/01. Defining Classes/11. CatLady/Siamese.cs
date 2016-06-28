namespace _11.CatLady
{
    public class Siamese : Cat
    {
        public int earSize;

        public Siamese(string name, int earSize)
            : base(name)
        {
            this.earSize = earSize;
        }

        public override string ToString()
        {
            string result = $"Siamese {this.name} {this.earSize}";

            return result;
        }
    }
}

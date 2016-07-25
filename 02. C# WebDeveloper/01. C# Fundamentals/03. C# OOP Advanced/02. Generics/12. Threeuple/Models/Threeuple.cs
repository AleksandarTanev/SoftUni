namespace _12.Threeuple.Models
{
    public class Threeuple<T, K, D>
    {
        public Threeuple(T item1, K item2, D item3)
        {
            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
        }

        public T Item1 { get; private set; }
        public K Item2 { get; private set; }
        public D Item3 { get; private set; }

        public override string ToString()
        {
            return $"{this.Item1} -> {this.Item2} -> {this.Item3}";
        }
    }
}

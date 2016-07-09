namespace _06.Animals
{
    using System;

    public class Frog : Animal
    {
        public Frog(string name, int age, string gendre) : base(name, age, gendre)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Frogggg");
        }
    }
}

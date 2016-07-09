namespace _06.Animals
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name, int age, string gendre) : base(name, age, gendre)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("BauBau");
        }
    }
}

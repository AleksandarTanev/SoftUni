namespace _06.Animals
{
    using System;

    public class Cat : Animal
    {
        public Cat(string name, int age, string gendre) : base(name, age, gendre)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("MiauMiau");
        }
    }
}

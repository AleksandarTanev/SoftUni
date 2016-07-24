namespace _03.Ferrari.Models
{
    using System;
    using Interfaces;

    public class Ferrari : ICar
    {
        public Ferrari(string model, string driver)
        {
            this.Model = model;
            this.Driver = driver;
        }

        public string Model { get; set; }
        public string Driver { get; set; }

        public void Gas()
        {
            Console.Write("Zadu6avam sA!");
        }

        public void Breaks()
        {
            Console.Write("Brakes!");
        }
    }
}

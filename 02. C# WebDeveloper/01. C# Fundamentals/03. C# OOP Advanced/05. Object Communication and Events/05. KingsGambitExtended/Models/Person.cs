namespace _05.KingsGambitExtended.Models
{
    using Interfaces;

    public abstract class Person : IPerson
    {
        protected Person(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}

namespace _07.FoodShortage.Models
{
    using Interfaces;

    class Pet : IPet
    {
        public Pet(string name, string birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public string Name { get; private set; }
        public string Birthday { get; private set; }
    }
}

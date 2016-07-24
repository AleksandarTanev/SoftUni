namespace _07.FoodShortage.Models
{
    using Interfaces;

    public class Citizen : Identity, ICitizen, IBuyer
    {
        public Citizen(string name, int age, string id, string birthday) : base(id)
        {
            this.Name = name;
            this.Age = age;
            this.Birthday = birthday;
            this.Food = 0;
        }

        public string Name { get; }
        public int Age { get; }
        public string Birthday { get; }
        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}

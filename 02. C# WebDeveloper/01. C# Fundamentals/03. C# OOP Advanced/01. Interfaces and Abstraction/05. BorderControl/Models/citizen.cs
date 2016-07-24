namespace _05.BorderControl.Models
{
    using Interfaces;

    public class Citizen : Identity, ICitizen
    {
        public Citizen(string name, int age, string id) : base(id)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; }
        public int Age { get; }
    }
}

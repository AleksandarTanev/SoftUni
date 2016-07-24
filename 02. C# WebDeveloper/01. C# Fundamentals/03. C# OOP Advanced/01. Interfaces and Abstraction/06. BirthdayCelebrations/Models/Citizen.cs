namespace _06.BirthdayCelebrations.Models
{
    using Interfaces;

    public class Citizen : Identity, ICitizen
    {
        public Citizen(string name, int age, string id, string birthday) : base(id)
        {
            this.Name = name;
            this.Age = age;
            this.Birthday = birthday;
        }

        public string Name { get; }
        public int Age { get; }
        public string Birthday { get; }
    }
}

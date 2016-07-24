namespace _08.MilitaryElite.Models
{
    using Interfaces;

    public abstract class Soldier : ISoldier
    {
        public Soldier(string firstName, string lastName, string id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string Id { get; }
    }
}

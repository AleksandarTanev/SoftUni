namespace _08.MilitaryElite.Models
{
    using Interfaces;

    public class Spy : Soldier, ISpy
    {
        public Spy(string firstName, string lastName, string id, long codeNumber) 
            : base(firstName, lastName, id)
        {
            this.CodeNumber = codeNumber;
        }

        public long CodeNumber { get; }

        public override string ToString()
        {
            string output = $"Name: {this.FirstName} {this.LastName} Id: {this.Id}";
            output += "\n";
            output += $"Code Number: {this.CodeNumber}";

            return output;
        }
    }
}

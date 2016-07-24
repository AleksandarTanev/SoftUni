namespace _08.MilitaryElite.Models
{
    using System.Collections.Generic;

    using Interfaces;

    public class Private : Soldier, IPrivate
    {
        public static List<IPrivate> privates = new List<IPrivate>();

        public Private(string firstName, string lastName, string id, decimal salary) 
            : base(firstName, lastName, id)
        {
            this.Salary = salary;

            privates.Add(this);
        }

        public decimal Salary { get; }

        public override string ToString()
        {
            string output = $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}";

            return output;
        }
    }
}

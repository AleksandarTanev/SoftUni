namespace _08.MilitaryElite.Models
{
    using Enums;
    using Interfaces;

    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(string firstName, string lastName, string id, decimal salary, Corp corp) 
            : base(firstName, lastName, id, salary)
        {
            this.AttendedCorp = corp;
        }

        public Corp AttendedCorp { get; }

        public override string ToString()
        {
            string output = $"Corps: {this.AttendedCorp}";

            return base.ToString() + "\n" + output;
        }
    }
}

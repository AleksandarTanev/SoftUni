namespace _08.MilitaryElite.Models
{
    using System.Collections.Generic;
    using System.Text;

    using Enums;
    using Interfaces;

    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string firstName, string lastName, string id, decimal salary, Corp corp) 
            : base(firstName, lastName, id, salary, corp)
        {
            this.Repairs = new HashSet<IRepair>();
        }

        public HashSet<IRepair> Repairs { get; private set; }

        public void AddRepair(IRepair repair)
        {
            this.Repairs.Add(repair);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append("\n" + "Repairs:");

            foreach (var repair in this.Repairs)
            {
                sb.Append("\n" + "  " + repair.ToString());
            }
            return sb.ToString();
        }
    }
}

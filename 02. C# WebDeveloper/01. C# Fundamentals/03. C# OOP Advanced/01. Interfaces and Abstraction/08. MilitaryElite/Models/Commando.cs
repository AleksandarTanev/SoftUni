namespace _08.MilitaryElite.Models
{
    using System.Collections.Generic;
    using System.Text;

    using Enums;
    using Interfaces;

    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string firstName, string lastName, string id, decimal salary, Corp corp) 
            : base(firstName, lastName, id, salary, corp)
        {
            this.Missions = new HashSet<IMission>();
        }

        public HashSet<IMission> Missions { get; private set; }

        public void AddMission(IMission mission)
        {
            this.Missions.Add(mission);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append("\n" + "Missions:");

            foreach (var mission in this.Missions)
            {
                sb.Append("\n" + mission.ToString());
            }
            return sb.ToString();
        }
    }
}

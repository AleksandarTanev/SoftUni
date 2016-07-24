namespace _08.MilitaryElite.Interfaces
{
    using System.Collections.Generic;

    public interface ICommando
    {
        HashSet<IMission> Missions { get; }

        void AddMission(IMission mission);
    }
}

namespace _08.MilitaryElite.Interfaces
{
    using System.Collections.Generic;

    public interface IEngineer
    {
        HashSet<IRepair> Repairs { get; }

        void AddRepair(IRepair repair);
    }
}

namespace _08.MilitaryElite.Interfaces
{
    using Enums;

    public interface IMission
    {
        string CodeName { get; }
        MissionState State { get; }

        void CompleteMission();
    }
}

namespace _05.KingsGambitExtended.Interfaces
{
    public interface IKillable
    {
        bool IsAlive { get; }
        int Hp { get; }

        void Kill();
    }
}

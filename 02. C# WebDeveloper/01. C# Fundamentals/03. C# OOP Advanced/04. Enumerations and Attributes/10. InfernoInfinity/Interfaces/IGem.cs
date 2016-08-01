namespace _10.InfernoInfinity.Interfaces
{
    using Enums;

    public interface IGem
    {
        IStats OriginalStats { get; }

        GemQuality Quality { get; }

        IStats GetTotalStats();
    }
}

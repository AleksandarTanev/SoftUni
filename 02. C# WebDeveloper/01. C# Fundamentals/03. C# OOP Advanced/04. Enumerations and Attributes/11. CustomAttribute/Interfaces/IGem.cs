namespace _11.CustomAttribute.Interfaces
{
    using Enums;

    public interface IGem
    {
        IStats OriginalStats { get; }

        GemQuality Quality { get; }

        IStats GetTotalStats();
    }
}

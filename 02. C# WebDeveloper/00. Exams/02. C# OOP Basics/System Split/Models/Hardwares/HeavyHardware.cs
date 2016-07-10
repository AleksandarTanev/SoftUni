namespace System_Split.Models.Hardwares
{
    using System;

    public class HeavyHardware : Hardware
    {
        public HeavyHardware(string name, string type, int _maximumCapacity, int _maximumMemory)
            : base(name, type, _maximumCapacity, _maximumMemory)
        {
        }

        public override int MaximumMemory
        {
            protected set { base.MaximumMemory = (int) Math.Round(value*0.75, 0, MidpointRounding.AwayFromZero); }
        }

        public override int MaximumCapacity
        {
            protected set { base.MaximumCapacity = (int) (value*2); }
        }
    }
}

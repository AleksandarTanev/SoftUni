namespace System_Split.Models.Hardwares
{
    using System;

    public class PowerHardware : Hardware
    {
        public PowerHardware(string name, string type, int _maximumCapacity, int _maximumMemory)
            : base(name, type, _maximumCapacity, _maximumMemory)
        {
        }

        public override int MaximumMemory
        {
            protected set { base.MaximumMemory = (int) Math.Round(value*1.75, 0, MidpointRounding.AwayFromZero); }
        }

        public override int MaximumCapacity
        {
            protected set { base.MaximumCapacity = (int) Math.Round(value*0.25, 0, MidpointRounding.AwayFromZero); }
        }
    }
}

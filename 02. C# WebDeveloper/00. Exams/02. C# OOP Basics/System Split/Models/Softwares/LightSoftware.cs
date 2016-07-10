namespace System_Split.Models.Softwares
{
    public class LightSoftware : Software
    {
        public LightSoftware(string name, string type, int capacityConsumption, int memoryConsumption)
            : base(name, type, capacityConsumption, memoryConsumption)
        {
        }

        public override int MemoryConsumption
        {
            protected set { base.MemoryConsumption = (int) (value*0.5); }
        }

        public override int CapacityConsumption
        {
            protected set { base.CapacityConsumption = (int) (value*1.5); }
        }
    }
}

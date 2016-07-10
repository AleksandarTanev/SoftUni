namespace System_Split.Models.Softwares
{
    public class ExpressSoftware : Software
    {
        public ExpressSoftware(string name, string type, int capacityConsumption, int memoryConsumption)
            : base(name, type, capacityConsumption, memoryConsumption)
        {
        }

        public override int MemoryConsumption
        {
            protected set { base.MemoryConsumption = value*2; }
        }
    }
}

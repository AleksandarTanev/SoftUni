namespace System_Split.Factories
{
    using Exceptions;
    using Models.Hardwares;

    public static class HardwareFactory
    {
        public static Hardware GenerateHardware(string type, string name, int capacityConsumption, int memoryConsumption)
        {
            Hardware newSoftware = null;

            if (type == "Heavy")
            {
                newSoftware = new HeavyHardware(name, type, capacityConsumption, memoryConsumption);
            }
            else if (type == "Power")
            {
                newSoftware = new PowerHardware(name, type, capacityConsumption, memoryConsumption);
            }

            if (newSoftware != null)
            {
                return newSoftware;
            }
            else
            {
                throw new InvalidHardwareType($"The hardware type '{type}' is not valid.");
            }
        }
    }
}

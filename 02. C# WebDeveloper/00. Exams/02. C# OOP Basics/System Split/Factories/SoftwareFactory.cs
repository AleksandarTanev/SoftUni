namespace System_Split.Factories
{
    using Exceptions;
    using Models.Softwares;

    public static class SoftwareFactory
    {
        public static Software GenerateSoftware(string type, string name, int capacityConsumption, int memoryConsumption)
        {
            Software newSoftware = null;

            if (type == "Express")
            {
                newSoftware = new ExpressSoftware(name, type, capacityConsumption, memoryConsumption);
            }
            else if (type == "Light")
            {
                newSoftware = new LightSoftware(name, type, capacityConsumption, memoryConsumption);
            }

            if (newSoftware != null)
            {
                return newSoftware;
            }
            else
            {
                throw new InvalidSoftwareType($"The software type '{type}' is not valid.");
            }
        }
    }
}

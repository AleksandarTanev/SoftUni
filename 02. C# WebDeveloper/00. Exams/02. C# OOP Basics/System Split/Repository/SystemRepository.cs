namespace System_Split.Repository
{
    using System.Collections.Generic;
    using System.Linq;

    using Models.Hardwares;

    public class SystemRepository
    {
        private List<Hardware> hardwareComponents;
        private List<Hardware> dumpedHardwareComponents;

        public SystemRepository()
        {
            this.hardwareComponents = new List<Hardware>();
            this.dumpedHardwareComponents = new List<Hardware>();
        }

        public void MoveHardwareFromRepositoryToDump(string hardwareName)
        {
            Hardware hwToModify = this.hardwareComponents.FirstOrDefault(h => h.Name == hardwareName);

            if (hwToModify == null)
            {
                return;
            }

            this.dumpedHardwareComponents.Add(hwToModify);
            this.hardwareComponents.Remove(hwToModify);
        }

        public void RestoreHardwareFromDumpToRepository(string hardwareName)
        {
            Hardware hwToModify = this.dumpedHardwareComponents.FirstOrDefault(h => h.Name == hardwareName);

            if (hwToModify == null)
            {
                return;
            }

            this.hardwareComponents.Add(hwToModify);
            this.dumpedHardwareComponents.Remove(hwToModify);
        }

        public void DestroyHardwareInDump(string hardwareName)
        {
            Hardware hwToModify = this.dumpedHardwareComponents.FirstOrDefault(h => h.Name == hardwareName);

            if (hwToModify == null)
            {
                return;
            }

            this.dumpedHardwareComponents.Remove(hwToModify);
        }

        public List<Hardware> GetDumpedHardwareComponents()
        {
            return this.dumpedHardwareComponents;
        }

        public List<Hardware> GetHardwareComponents()
        {
            return this.hardwareComponents;
        }

        public int GetMaximumSystemMemory()
        {
            int maximumMemory = this.hardwareComponents.Sum(h => h.MaximumMemory);

            return maximumMemory;
        }

        public int GetMaximumSystemCapacity()
        {
            int maximumCapacity = this.hardwareComponents.Sum(h => h.MaximumCapacity);

            return maximumCapacity;
        }

        public int GetTotalOperationalMemoryInUse()
        {
            int totalOperationalMemoryInUse = this.hardwareComponents
                .Sum(h => h.GetSoftwareComponents()
                .Sum(s => s.MemoryConsumption));

            return totalOperationalMemoryInUse;
        }

        public int GetTotalOperationalCapacityInUse()
        {
            int totalOperationalMemoryInUse = this.hardwareComponents
                .Sum(h => h.GetSoftwareComponents()
                .Sum(s => s.CapacityConsumption));

            return totalOperationalMemoryInUse;
        }

        public int GetQuantityOfSoftwareComponentsInUse()
        {
            int countOfSoftwareComponents = this.hardwareComponents.Sum(h => h.GetSoftwareComponents().Count);

            return countOfSoftwareComponents;
        }
    }
}

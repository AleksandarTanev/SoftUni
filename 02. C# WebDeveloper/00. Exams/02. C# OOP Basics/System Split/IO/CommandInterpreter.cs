namespace System_Split.IO
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    using Factories;
    using Models.Hardwares;
    using Models.Softwares;
    using Repository;

    public class CommandInterpreter
    {
        private const string SplitLinePattern = @"(.*?)\((.*?)\)";

        private SystemRepository repository;

        public CommandInterpreter(SystemRepository repository)
        {
            this.repository = repository;
        }

        public void InterpretCommand(string line)
        {
            if (line == "System Split")
            {
                SystemSplit();
                return;
            }

            Match match = Regex.Match(line, SplitLinePattern);

            string command = match.Groups[1].ToString();
            string[] values = match.Groups[2]
                .ToString()
                .Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToArray();

            switch (command)
            {
                case "RegisterPowerHardware":
                    RegisterPowerHardware(values);
                    break;
                case "RegisterHeavyHardware":
                    RegisterHeavyHardware(values);
                    break;
                case "RegisterExpressSoftware":
                    RegisterExpressSoftware(values);
                    break;
                case "RegisterLightSoftware":
                    RegisterLightSoftware(values);
                    break;
                case "ReleaseSoftwareComponent":
                    ReleaseSoftwareComponent(values);
                    break;
                case "Analyze":
                    Analyze();
                    break;
                case "Dump":
                    Dump(values);
                    break;
                case "Restore":
                    Restore(values);
                    break;
                case "Destroy":
                    Destroy(values);
                    break;
                case "DumpAnalyze":
                    DumpAnalyze();
                    break;
                default:
                    throw new InvalidOperationException($"Line {line} cannot be interpreted.");
            }
        }

        private void RegisterPowerHardware(string[] tokens)
        {
            if (tokens.Length != 3)
            {
                throw new ArgumentException($"Invalid number of arguments. Expected 3, but received {tokens.Length}.");
            }

            string name = tokens[0];
            int capacity = int.Parse(tokens[1]);
            int memory = int.Parse(tokens[2]);

            Hardware newHardware = HardwareFactory.GenerateHardware("Power", name, capacity, memory);

            repository.GetHardwareComponents().Add(newHardware);
        }

        private void RegisterHeavyHardware(string[] tokens)
        {
            if (tokens.Length != 3)
            {
                throw new ArgumentException($"Invalid number of arguments. Expected 3, but received {tokens.Length}.");
            }

            string name = tokens[0];
            int capacity = int.Parse(tokens[1]);
            int memory = int.Parse(tokens[2]);

            Hardware newHardware = HardwareFactory.GenerateHardware("Heavy", name, capacity, memory);

            repository.GetHardwareComponents().Add(newHardware);
        }

        private void RegisterExpressSoftware(string[] tokens)
        {
            if (tokens.Length != 4)
            {
                throw new ArgumentException($"Invalid number of arguments. Expected 4, but received {tokens.Length}.");
            }

            string hardwareName = tokens[0];
            string name = tokens[1];
            int capacityCons = int.Parse(tokens[2]);
            int memoryCons = int.Parse(tokens[3]);

            Software newSoftware = SoftwareFactory.GenerateSoftware("Express", name, capacityCons, memoryCons);

            Hardware hwToModify = repository.GetHardwareComponents().FirstOrDefault(h => h.Name == hardwareName);

            if (hwToModify != null)
            {
                hwToModify.AddSoftwareComponent(newSoftware);
            }
        }

        private void RegisterLightSoftware(string[] tokens)
        {
            if (tokens.Length != 4)
            {
                throw new ArgumentException($"Invalid number of arguments. Expected 4, but received {tokens.Length}.");
            }

            string hardwareName = tokens[0];
            string name = tokens[1];
            int capacityCons = int.Parse(tokens[2]);
            int memoryCons = int.Parse(tokens[3]);

            Software newSoftware = SoftwareFactory.GenerateSoftware("Light", name, capacityCons, memoryCons);

            Hardware hwToModify = repository.GetHardwareComponents().FirstOrDefault(h => h.Name == hardwareName);

            if (hwToModify != null)
            {
                hwToModify.AddSoftwareComponent(newSoftware);
            }
        }

        private void ReleaseSoftwareComponent(string[] tokens)
        {
            if (tokens.Length != 2)
            {
                throw new ArgumentException($"Invalid number of arguments. Expected 2, but received {tokens.Length}.");
            }

            string hardwareName = tokens[0];
            string softwareName = tokens[1];

            Hardware hwToModify = repository.GetHardwareComponents().FirstOrDefault(h => h.Name == hardwareName);

            if (hwToModify == null)
            {
                return;
            }

            hwToModify.RemoveSoftwareComponent(softwareName);
        }

        private void Analyze()
        {
            Console.WriteLine("System Analysis");

            int countOfHardwareComponents = this.repository.GetHardwareComponents().Count;
            Console.WriteLine($"Hardware Components: {countOfHardwareComponents}");

            int countOfSoftwareComponents = this.repository.GetQuantityOfSoftwareComponentsInUse();
            Console.WriteLine($"Software Components: {countOfSoftwareComponents}");

            int totalOperationalMemoryInUse = this.repository.GetTotalOperationalMemoryInUse();
            int maximumMemory = this.repository.GetMaximumSystemMemory();
            Console.WriteLine($"Total Operational Memory: {totalOperationalMemoryInUse} / {maximumMemory}");

            int totalOperationalCapacityInUse = this.repository.GetTotalOperationalCapacityInUse();
            int maximumCapacity = this.repository.GetMaximumSystemCapacity();
            Console.WriteLine($"Total Capacity Taken: {totalOperationalCapacityInUse} / {maximumCapacity}");
        }

        private void SystemSplit()
        {
            var listPowerHardware = this.repository.GetHardwareComponents().Where(h => h.Type == "Power");
            var listHeavyHardware = this.repository.GetHardwareComponents().Where(h => h.Type == "Heavy");

            foreach (var hardware in listPowerHardware)
            {
                Console.WriteLine(hardware);
            }

            foreach (var hardware in listHeavyHardware)
            {
                Console.WriteLine(hardware);
            }
        }

        private void Dump(string[] tokens)
        {
            if (tokens.Length != 1)
            {
                throw new ArgumentException($"Invalid number of arguments. Expected 1, but received {tokens.Length}.");
            }

            string hardwareName = tokens[0];

            this.repository.MoveHardwareFromRepositoryToDump(hardwareName);
        }

        private void Restore(string[] tokens)
        {
            if (tokens.Length != 1)
            {
                throw new ArgumentException($"Invalid number of arguments. Expected 1, but received {tokens.Length}.");
            }

            string hardwareName = tokens[0];

            this.repository.RestoreHardwareFromDumpToRepository(hardwareName);
        }

        private void Destroy(string[] tokens)
        {
            if (tokens.Length != 1)
            {
                throw new ArgumentException($"Invalid number of arguments. Expected 1, but received {tokens.Length}.");
            }

            string hardwareName = tokens[0];

            this.repository.DestroyHardwareInDump(hardwareName);
        }

        private void DumpAnalyze()
        {
            Console.WriteLine("Dump Analysis");

            int countOfPowerHardwareComponents = this.repository.GetDumpedHardwareComponents().Count(h => h is PowerHardware);
            Console.WriteLine($"Power Hardware Components: {countOfPowerHardwareComponents}");

            int countOfHeavyHardwareComponents = this.repository.GetDumpedHardwareComponents().Count(h => h is HeavyHardware);
            Console.WriteLine($"Heavy Hardware Components: {countOfHeavyHardwareComponents}");

            int countOfExpressSoftwareComponents = this.repository.GetDumpedHardwareComponents().Sum(h => h.GetSoftwareComponents().Count(s => s is ExpressSoftware));
            Console.WriteLine($"Express Software Components: {countOfExpressSoftwareComponents}");

            int countOfLightSoftwareComponents = this.repository.GetDumpedHardwareComponents().Sum(h => h.GetSoftwareComponents().Count(s => s is LightSoftware));
            Console.WriteLine($"Light Software Components: {countOfLightSoftwareComponents}");

            int totalDumpedMemory =
                this.repository.GetDumpedHardwareComponents()
                .Sum(h => h.GetSoftwareComponents()
                .Sum(s => s.MemoryConsumption));
            Console.WriteLine($"Total Dumped Memory: {totalDumpedMemory}");

            int totalDumpedCapacity =
                this.repository.GetDumpedHardwareComponents()
                .Sum(h => h.GetSoftwareComponents()
                .Sum(s => s.CapacityConsumption));
            Console.WriteLine($"Total Dumped Capacity: {totalDumpedCapacity}");
        }
    }
}

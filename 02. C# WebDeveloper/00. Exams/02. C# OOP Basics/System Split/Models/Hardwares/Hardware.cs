namespace System_Split.Models.Hardwares
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Exceptions;
    using Models;
    using Softwares;

    public abstract class Hardware : ComputerComponent
    {
        private int maximumCapacity;
        private int maximumMemory;

        private int currentCapacity;
        private int currentMemory;

        private List<Software> softwareComponents;

        protected Hardware(string name, string type, int maximumCapacity, int maximumMemory)
            : base(name, type)
        {
            this.MaximumCapacity = maximumCapacity;
            this.MaximumMemory = maximumMemory;

            this.CurrentCapacity = this.MaximumCapacity;
            this.CurrentMemory = this.MaximumMemory;

            this.softwareComponents = new List<Software>();
        }

        public override string Type
        {
            protected set
            {
                if (value != "Power" && value != "Heavy")
                {
                    throw new InvalidHardwareType($"The hardware type '{value}' is not valid.");
                }

                base.Type = value;
            }
        }

        public virtual int MaximumCapacity
        {
            get
            {
                return maximumCapacity;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"The {nameof(this.maximumCapacity)} cannot be negative.");
                }

                maximumCapacity = value;
            }
        }

        public virtual int MaximumMemory
        {
            get
            {
                return maximumMemory;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"The {nameof(this.MaximumMemory)} cannot be negative.");
                }

                maximumMemory = value;
            }
        }

        public int CurrentCapacity
        {
            get
            {
                return currentCapacity;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"The {nameof(this.CurrentCapacity)} cannot be negative.");
                }

                currentCapacity = value;
            }
        }

        public int CurrentMemory
        {
            get
            {
                return currentMemory;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"The {nameof(this.CurrentMemory)} cannot be negative.");
                }

                currentMemory = value;
            }
        }

        public void AddSoftwareComponent(Software softwareComponent)
        {
            if (this.CurrentMemory - softwareComponent.MemoryConsumption < 0 || this.CurrentCapacity - softwareComponent.CapacityConsumption < 0)
            {
                return;
            }

            this.CurrentMemory -= softwareComponent.MemoryConsumption;
            this.CurrentCapacity -= softwareComponent.CapacityConsumption;

            this.softwareComponents.Add(softwareComponent);
        }

        public void RemoveSoftwareComponent(string softwareComponentName)
        {
            Software swToRemove = this.softwareComponents.FirstOrDefault(s => s.Name == softwareComponentName);

            if (swToRemove == null)
            {
                return;
            }

            this.CurrentCapacity += swToRemove.CapacityConsumption;
            this.CurrentMemory += swToRemove.MemoryConsumption;

            this.softwareComponents.Remove(swToRemove);
        }

        public List<Software> GetSoftwareComponents()
        {
            return this.softwareComponents;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Hardware Component - {this.Name}");
            sb.Append($"\n");

            int countOfExpressSoftwareComponents = this.softwareComponents.Count(s => s is ExpressSoftware);
            sb.Append($"Express Software Components - {countOfExpressSoftwareComponents}");
            sb.Append($"\n");

            int countOfLightSoftwareComponents = this.softwareComponents.Count(s => s is LightSoftware);
            sb.Append($"Light Software Components - {countOfLightSoftwareComponents}");
            sb.Append($"\n");

            int memoryUsed =
                this.softwareComponents
                .Sum(s => s.MemoryConsumption);
            sb.Append($"Memory Usage: {memoryUsed} / {this.MaximumMemory}");
            sb.Append($"\n");

            int capacityUsed =
                this.softwareComponents
                .Sum(s => s.CapacityConsumption);
            sb.Append($"Capacity Usage: {capacityUsed} / {this.MaximumCapacity}");
            sb.Append($"\n");

            sb.Append($"Type: {this.Type}");
            sb.Append($"\n");

            if (this.softwareComponents.Count == 0)
            {
                sb.Append($"Software Components: None");
            }
            else
            {
                sb.Append($"Software Components: {string.Join(", ", this.softwareComponents)}");
            }

            return sb.ToString();
        }
    }
}

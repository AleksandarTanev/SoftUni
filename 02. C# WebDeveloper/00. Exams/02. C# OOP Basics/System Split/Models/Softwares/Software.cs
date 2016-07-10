namespace System_Split.Models.Softwares
{
    using System;

    using Exceptions;

    public abstract class Software : ComputerComponent
    {
        private int capacityConsumption;
        private int memoryConsumption;

        protected Software(string name, string type, int capacityConsumption, int memoryConsumption)
            : base(name, type)
        {
            this.CapacityConsumption = capacityConsumption;
            this.MemoryConsumption = memoryConsumption;
        }

        public override string Type
        {
            protected set
            {
                if (value != "Light" && value != "Express")
                {
                    throw new InvalidSoftwareType($"The software type '{value}' is not valid.");
                }

                base.Type = value;
            }
        }

        public virtual int CapacityConsumption
        {
            get
            {
                return capacityConsumption;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"The {nameof(this.CapacityConsumption)} cannot be negative.");
                }

                capacityConsumption = value;
            }
        }

        public virtual int MemoryConsumption
        {
            get
            {
                return memoryConsumption;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"The {nameof(this.MemoryConsumption)} cannot be negative.");
                }

                memoryConsumption = value;
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}

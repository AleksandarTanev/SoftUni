namespace _02.VehiclesExtension.Vehicles
{
    using System;

    public class Bus : Vehicle
    {
        private bool isEmpty = true;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }


        public override double FuelQuantity
        {
            set
            {
                if (value > this.TankCapacity)
                {
                    Console.WriteLine("Cannot fit fuel in tank");
                }
                else
                {
                    base.FuelQuantity = value;
                }
            }
        }

        public override double FuelConsumption
        {
            get
            {
                if (IsEmpty)
                {
                    return base.FuelConsumption;
                }
                else
                {
                    return base.FuelConsumption + 1.4;
                }
            }
        }

        public bool IsEmpty
        {
            get
            {
                return isEmpty;
            }

            set
            {
                isEmpty = value;
            }
        }

        public override void ReFuel(double fuel)
        {
            if (this.FuelQuantity + fuel > this.TankCapacity)
            {
                Console.WriteLine("Cannot fit fuel in tank");
            }
            else
            {
                base.FuelQuantity += fuel;
            }
        }
    }
}

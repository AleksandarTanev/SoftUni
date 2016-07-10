namespace _02.VehiclesExtension.Vehicles
{
    using System;

    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption
        {
            set
            {
                base.FuelConsumption = value + 0.9;
            }
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

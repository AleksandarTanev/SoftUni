namespace _02.VehiclesExtension.Vehicles
{
    using System;

    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption
        {
            set
            {
                base.FuelConsumption = value + 1.6;
            }
        }

        public override void ReFuel(double fuel)
        {
            this.FuelQuantity += fuel * 0.95;
        }
    }
}

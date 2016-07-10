namespace _01.Vehicles.Vehicles
{
    using System;

    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
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

        public override void Travel(double distance)
        {
            double fuelNeeded = distance * this.FuelConsumption;
            if (fuelNeeded > this.FuelQuantity)
            {
                Console.WriteLine($"Truck needs refueling");
                return;
            }

            this.FuelQuantity -= fuelNeeded;
            this.Distance += distance;
            Console.WriteLine($"Truck travelled {distance} km");
        }
    }
}

namespace _01.Vehicles.Vehicles
{
    using System;

    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
        }

        public override double FuelConsumption
        {
            set
            {
                base.FuelConsumption = value + 0.9;
            }
        }

        public override void Travel(double distance)
        {
            double fuelNeeded = distance * this.FuelConsumption;
            if (fuelNeeded > this.FuelQuantity)
            {
                Console.WriteLine($"Car needs refueling");
                return;
            }

            this.FuelQuantity -= fuelNeeded;
            this.Distance += distance;
            Console.WriteLine($"Car travelled {distance} km");

        }
    }
}

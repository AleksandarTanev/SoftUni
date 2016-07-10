namespace _01.Vehicles.Vehicles
{
    using System;

    public class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double distance = 0;

        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public virtual double FuelQuantity
        {
            get { return fuelQuantity; }

            set { fuelQuantity = value; }
        }

        public virtual double FuelConsumption
        {
            get { return fuelConsumption; }

            set { fuelConsumption = value; }
        }

        public virtual double Distance
        {
            get { return distance; }

            set { distance = value; }
        }

        public virtual void ReFuel(double fuel)
        {
            this.FuelQuantity += fuel;
        }

        public virtual void Travel(double distance)
        {
            double fuelNeeded = distance * this.FuelConsumption;
            if (fuelNeeded > this.FuelQuantity)
            {
                Console.WriteLine($"Vehicle needs refueling");
                return;
            }

            this.FuelQuantity -= fuelNeeded;
            this.Distance += distance;
            Console.WriteLine($"Vehicle travelled {distance} km");
        }
    }
}

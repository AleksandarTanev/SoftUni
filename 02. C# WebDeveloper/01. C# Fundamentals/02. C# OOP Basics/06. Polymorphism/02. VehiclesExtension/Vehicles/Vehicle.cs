namespace _02.VehiclesExtension.Vehicles
{
    using System;

    public class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        private double distance = 0;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public virtual double FuelQuantity
        {
            get { return fuelQuantity; }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Fuel must be a positive number");
                }
                else
                {
                    fuelQuantity = value;
                }
            }
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

        public double TankCapacity
        {
            get
            {
                return tankCapacity;
            }

            set
            {
                tankCapacity = value;
            }
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
                Console.WriteLine($"{this.GetType().Name} needs refueling");
                return;
            }

            this.FuelQuantity -= fuelNeeded;
            this.Distance += distance;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }
    }
}

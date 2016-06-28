namespace _05.SpeedRacing
{
    using System;

    class Car
    {
        public string model;
        public decimal fuel;
        public decimal fuelPerKm;
        public int distanceTraveled = 0;

        public Car(string model, decimal fuel, decimal fuelPerKm)
        {
            this.model = model;
            this.fuel = fuel;
            this.fuelPerKm = fuelPerKm;
        }

        public void TravelDistance(int distance)
        {
            decimal fuelNeeded = this.fuelPerKm * distance;
            
            if (fuelNeeded > this.fuel)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.fuel -= fuelNeeded;
                this.distanceTraveled += distance;
            }
        }
    }
}

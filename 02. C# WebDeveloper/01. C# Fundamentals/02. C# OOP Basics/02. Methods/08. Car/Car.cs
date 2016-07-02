namespace _08.Car
{
    using System;

    public class Car
    {
        public int speed;
        public double fuel;
        public double fuelPerKm;

        public double distance = 0;
        public int travelTime = 0;

        public Car(int speed, double fuel, double fuelPerKm)
        {
            this.speed = speed;
            this.fuel = fuel;
            this.fuelPerKm = fuelPerKm;
        }

        public void Travel(double distance)
        {
            double maxDistance = (this.fuel / this.fuelPerKm) * this.speed;

            if (distance < maxDistance)
            {
                this.distance += distance;
                this.fuel -= (distance / this.speed) * this.fuelPerKm;
                this.travelTime += (int)(distance / this.speed) * 60;
            }
            else
            {
                this.distance += maxDistance;
                this.fuel = 0;
                this.travelTime += (int)(maxDistance / this.speed) * 60;
            }
        }

        public void Refuel(double fuel)
        {
            this.fuel += fuel;
        }

        public void Distance()
        {
            Console.WriteLine($"Total distance: {this.distance:F1} kilometers");
        }

        public void Time()
        {
            Console.WriteLine($"Total time: {this.travelTime / 60} hours and {this.travelTime % 60} minutes");
        }

        public void Fuel()
        {
            Console.WriteLine($"Fuel left: {this.fuel:F1} liters");
        }
    }
}

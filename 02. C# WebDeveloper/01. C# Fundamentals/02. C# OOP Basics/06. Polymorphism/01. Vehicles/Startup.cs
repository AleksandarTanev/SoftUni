namespace _01.Vehicles
{
    using System;
    using Vehicles;

    public class Startup
    {
        public static void Main()
        {
            var tokens = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            double fuel = double.Parse(tokens[1]);
            double fuelCons = double.Parse(tokens[2]);

            var car = new Car(fuel, fuelCons);

            tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            fuel = double.Parse(tokens[1]);
            fuelCons = double.Parse(tokens[2]);

            var truck = new Truck(fuel, fuelCons);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];
                string vehicle = tokens[1];
                double value = double.Parse(tokens[2]);

                if (command == "Drive")
                {
                    if (vehicle == "Car")
                    {
                        car.Travel(value);
                    }
                    else
                    {
                        truck.Travel(value);
                    }
                }
                else if (command == "Refuel")
                {
                    if (vehicle == "Car")
                    {
                        car.ReFuel(value);
                    }
                    else
                    {
                        truck.ReFuel(value);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
        }
    }
}

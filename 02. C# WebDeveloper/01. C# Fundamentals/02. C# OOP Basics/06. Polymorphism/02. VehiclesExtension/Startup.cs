namespace _02.VehiclesExtension
{
    using System;
    using Vehicles;

    public class Startup
    {
        public static void Main()
        {
            var tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double fuel = double.Parse(tokens[1]);
            double fuelCons = double.Parse(tokens[2]);
            double tankCap = double.Parse(tokens[3]);
            var car = new Car(fuel, fuelCons, tankCap);

            tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            fuel = double.Parse(tokens[1]);
            fuelCons = double.Parse(tokens[2]);
            tankCap = double.Parse(tokens[3]);
            var truck = new Truck(fuel, fuelCons, tankCap);

            tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            fuel = double.Parse(tokens[1]);
            fuelCons = double.Parse(tokens[2]);
            tankCap = double.Parse(tokens[3]);
            var bus = new Bus(fuel, fuelCons, tankCap);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                try
                {
                    tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    string command = tokens[0];
                    string vehicle = tokens[1];
                    double value = double.Parse(tokens[2]);

                    if (vehicle == "Car")
                    {
                        if (command == "Drive")
                        {
                            car.Travel(value);
                        }
                        else if (command == "Refuel")
                        {
                            car.ReFuel(value);
                        }
                    }
                    else if (vehicle == "Truck")
                    {
                        if (command == "Drive")
                        {
                            truck.Travel(value);
                        }
                        else if (command == "Refuel")
                        {
                            truck.ReFuel(value);
                        }
                    }
                    else if (vehicle == "Bus")
                    {
                        if (command == "Drive")
                        {
                            bus.IsEmpty = false;
                            bus.Travel(value);
                        }
                        else if (command == "Refuel")
                        {
                            bus.ReFuel(value);
                        }
                        else if (command == "DriveEmpty")
                        {
                            bus.IsEmpty = true;
                            bus.Travel(value);
                        }
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");
        }
    }
}

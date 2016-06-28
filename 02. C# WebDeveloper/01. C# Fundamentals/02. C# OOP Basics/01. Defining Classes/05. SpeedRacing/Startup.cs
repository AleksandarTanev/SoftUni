namespace _05.SpeedRacing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                decimal fuel = decimal.Parse(input[1]);
                decimal fuelPerKm = decimal.Parse(input[2]);

                cars.Add(model, new Car(model, fuel, fuelPerKm));
            }

            string inputCommand = Console.ReadLine();

            while (inputCommand != "End")
            {
                var tokens = inputCommand
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = tokens[1];
                int distance = int.Parse(tokens[2]);

                cars[model].TravelDistance(distance);

                inputCommand = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Value.model} {car.Value.fuel:F2} {car.Value.distanceTraveled}");
            }
        }
    }
}

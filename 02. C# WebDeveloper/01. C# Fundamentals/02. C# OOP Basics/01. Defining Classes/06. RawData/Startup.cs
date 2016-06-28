namespace _06.RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                int engSpeed = int.Parse(input[1]);
                int engPower = int.Parse(input[2]);
                int cargWeight = int.Parse(input[3]);
                string cargType = input[4];

                double tirePress1 = double.Parse(input[5]);
                int tireAge1 = int.Parse(input[6]);

                double tirePress2 = double.Parse(input[7]);
                int tireAge2 = int.Parse(input[8]);

                double tirePress3 = double.Parse(input[9]);
                int tireAge3 = int.Parse(input[10]);

                double tirePress4 = double.Parse(input[11]);
                int tireAge4 = int.Parse(input[12]);

                cars.Add(new Car(model, engSpeed, engPower, cargWeight, cargType, tirePress1, tireAge1, tirePress2, tireAge2, tirePress3, tireAge3, tirePress4, tireAge4));
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                var output = cars
                    .Where(c => c.cargo.cargoType == "fragile" && c.tires.Any(t => t.tirePressure < 1))
                    .ToList();

                foreach (var car in output)
                {
                    Console.WriteLine(car.model);
                }
            }
            else if (command == "flamable")
            {
                var output = cars
                    .Where(c => c.cargo.cargoType == "flamable" && c.engine.enginePower > 250)
                    .ToList();

                foreach (var car in output)
                {
                    Console.WriteLine(car.model);
                }
            }
        }
    }
}

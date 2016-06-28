namespace _07.CarSalesman
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var engines = new Dictionary<string, Engine>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                int power = int.Parse(input[1]);

                if (input.Length == 2)
                {
                    engines[model] = new Engine(model, power);
                }
                else if (input.Length == 3)
                {
                    int displacement;
                    if (int.TryParse(input[2], out displacement))
                    {
                        engines[model] = new Engine(model, power, displacement);
                    }
                    else
                    {
                        string efficiency = input[2];
                        engines[model] = new Engine(model, power, efficiency);
                    }
                }
                else if (input.Length == 4)
                {
                    int displacement = int.Parse(input[2]);
                    string efficiency = input[3];

                    engines[model] = new Engine(model, power, displacement, efficiency);
                }
            }

            var cars = new List<Car>();

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                string engine = input[1];

                if (input.Length == 2)
                {
                    cars.Add(new Car(model, engines[engine]));
                }
                else if (input.Length == 3)
                {
                    int weight;
                    if (int.TryParse(input[2], out weight))
                    {
                        cars.Add(new Car(model, engines[engine], weight));
                    }
                    else
                    {
                        string color = input[2];
                        cars.Add(new Car(model, engines[engine], color));
                    }
                }
                else if (input.Length == 4)
                {
                    int weight = int.Parse(input[2]);
                    string color = input[3];

                    cars.Add(new Car(model, engines[engine], weight, color));
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}

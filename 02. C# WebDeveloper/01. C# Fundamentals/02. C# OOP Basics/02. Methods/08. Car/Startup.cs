namespace _08.Car
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string[] tokens = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var car = new Car(int.Parse(tokens[0]), double.Parse(tokens[1]), double.Parse(tokens[2]));

            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "END")
            {
                if (input[0] == "Travel")
                {
                    car.Travel(double.Parse(input[1]));
                }
                else if (input[0] == "Refuel")
                {
                    car.Refuel(double.Parse(input[1]));
                }
                else if (input[0] == "Distance")
                {
                    car.Distance();
                }
                else if (input[0] == "Time")
                {
                    car.Time();
                }
                else if (input[0] == "Fuel")
                {
                    car.Fuel();
                }

                input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}

namespace _03.TemperatureConverter
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            while (input != "End")
            {
                var tokens = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                if (tokens[1] == "Fahrenheit")
                {
                    TemperatureModifier.FahrenheitToCelsius(double.Parse(tokens[0]));
                }
                else if (tokens[1] == "Celsius")
                {
                    TemperatureModifier.CelsiusToFahrenheit(double.Parse(tokens[0]));
                }

                input = Console.ReadLine();
            }
        }
    }
}

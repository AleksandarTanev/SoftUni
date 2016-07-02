namespace _03.TemperatureConverter
{
    using System;

    public class TemperatureModifier
    {
        public static void CelsiusToFahrenheit(double t)
        {
            double newTemp = (t * 1.8) + 32;

            Console.WriteLine($"{newTemp:F2} Fahrenheit");
        }

        public static void FahrenheitToCelsius(double t)
        {
            double newTemp = (t - 32) / 1.8;

            Console.WriteLine($"{newTemp:F2} Celsius");
        }
    }
}

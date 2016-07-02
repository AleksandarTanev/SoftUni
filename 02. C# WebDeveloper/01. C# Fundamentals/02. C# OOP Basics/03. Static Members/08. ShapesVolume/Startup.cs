namespace _08.ShapesVolume
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            while (input != "End")
            {
                var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                double result = 0;
                if (command == "Cube")
                {
                    double a = double.Parse(tokens[1]);

                    result = VolumeCalculator.CalculateVolume(new Cube(a));
                }
                else if (command == "Cylinder")
                {
                    double a = double.Parse(tokens[1]);
                    double b = double.Parse(tokens[2]);

                    result = VolumeCalculator.CalculateVolume(new Cylinder(a, b));
                }
                else if (command == "TrianglePrism")
                {
                    double a = double.Parse(tokens[1]);
                    double b = double.Parse(tokens[2]);
                    double c = double.Parse(tokens[3]);

                    result = VolumeCalculator.CalculateVolume(new TriangularPrism(a, b, c));
                }
                Console.WriteLine($"{result:F3}");

                input = Console.ReadLine();
            }
        }
    }
}

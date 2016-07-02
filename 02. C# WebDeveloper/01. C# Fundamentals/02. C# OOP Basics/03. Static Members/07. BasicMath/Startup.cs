namespace _07.BasicMath
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
                double a = double.Parse(tokens[1]);
                double b = double.Parse(tokens[2]);

                double result = 0;
                if (command == "Sum")
                {
                    result = MathUtil.Sum(a, b);
                }
                else if (command == "Subtract")
                {
                    result = MathUtil.Subtract(a, b);
                }
                else if (command == "Multiply")
                {
                    result = MathUtil.Multiply(a, b);
                }
                else if (command == "Divide")
                {
                    result = MathUtil.Divide(a, b);
                }
                else if (command == "Percentage")
                {
                    result = MathUtil.Percentage(a, b);
                }
                Console.WriteLine($"{result:F2}");

                input = Console.ReadLine();
            }
        }
    }
}

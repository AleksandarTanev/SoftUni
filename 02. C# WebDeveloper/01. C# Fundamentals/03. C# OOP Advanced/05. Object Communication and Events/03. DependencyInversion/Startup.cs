namespace _03.DependencyInversion
{
    using System;

    using Models;

    public class Startup
    {
        public static void Main()
        {
            var primitiveCalculator = new PrimitiveCalculator(new AdditionStrategy());

            string input = Console.ReadLine();
            while (input != "End")
            {
                var tokens = input.Split();

                if (tokens[0] == "mode")
                {
                    var newOperator = tokens[1];

                    switch (newOperator)
                    {
                        case "+":
                            {
                                primitiveCalculator.ChangeStrategy(new AdditionStrategy());
                                break;
                            }

                        case "-":
                            {
                                primitiveCalculator.ChangeStrategy(new SubtractionStrategy());
                                break;
                            }

                        case "*":
                            {
                                primitiveCalculator.ChangeStrategy(new MultiplyingStrategy());
                                break;
                            }

                        case "/":
                            {
                                primitiveCalculator.ChangeStrategy(new DividingStrategy());
                                break;
                            }
                    }
                }
                else
                {
                    int firstNumber = int.Parse(tokens[0]);
                    int secondNumber = int.Parse(tokens[1]);
                    Console.WriteLine(primitiveCalculator.PerformCalculation(firstNumber, secondNumber));
                }

                input = Console.ReadLine();
            }
        }
    }
}

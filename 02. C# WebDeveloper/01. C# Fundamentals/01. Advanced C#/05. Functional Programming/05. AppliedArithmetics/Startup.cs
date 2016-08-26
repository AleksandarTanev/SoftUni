namespace _05.AppliedArithmetics
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Func<int, int> add = n => n + 1;
            Func<int, int> multiply = n => n * 2;
            Func<int, int> subtract = n => n - 1;

            Action<int[]> print = c => Console.WriteLine(string.Join(" ", c));

            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "add")
                {
                    ApplyArithmetic(input, add);
                }
                else if (command == "multiply")
                {
                    ApplyArithmetic(input, multiply);
                }
                else if (command == "subtract")
                {
                    ApplyArithmetic(input, subtract);
                }
                else if (command == "print")
                {
                    print(input);
                }

                command = Console.ReadLine();
            }
        }

        public static void ApplyArithmetic(int[] collection, Func<int, int> arithmetic)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                collection[i] = arithmetic(collection[i]);
            }
        }
    }
}

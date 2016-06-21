namespace _03.MaximumElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MaximumElement
    {
        static void Main()
        {
            int numOfQuaries = int.Parse(Console.ReadLine());
            Stack<int> stackOfNumbers = new Stack<int>();

            int maxValue = int.MinValue;

            for (int i = 0; i < numOfQuaries; i++)
            {
                int[] input = Console.ReadLine()
                    .Trim()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int command = input[0];
                if (command == 1)
                {
                    if (maxValue < input[1])
                    {
                        maxValue = input[1];
                    }
                    stackOfNumbers.Push(input[1]);
                }
                else if (command == 2)
                {
                    int removedNumber = stackOfNumbers.Pop();
                    if (stackOfNumbers.Count == 0)
                    {
                        maxValue = int.MinValue;
                    }
                    else if (removedNumber == maxValue)
                    {
                        maxValue = stackOfNumbers.Max();
                    }
                }
                else if (command == 3)
                {
                    Console.WriteLine(maxValue);
                }
            }
        }
    }
}
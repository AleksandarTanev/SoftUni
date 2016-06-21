namespace _01.ReverseNumbersWithStack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ReverseNumbers
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Trim()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stackOfNumbers = new Stack<int>();

            foreach (var number in numbers)
            {
                stackOfNumbers.Push(number);
            }

            foreach (var number in stackOfNumbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
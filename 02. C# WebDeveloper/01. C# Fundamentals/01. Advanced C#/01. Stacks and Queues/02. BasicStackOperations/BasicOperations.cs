namespace _02.BasicStackOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class BasicOperations
    {
        static void Main()
        {
            int[] commands = Console.ReadLine()
                .Trim()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numbersToPush = commands[0];
            int numbersToPop = commands[1];
            int numberToSearch = commands[2];


            int[] numbers = Console.ReadLine()
                .Trim()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stackOfNumbers = new Stack<int>();

            if (numbersToPush > numbers.Length)
            {
                numbersToPush = numbers.Length;
            }

            if (numbersToPop > numbersToPush)
            {
                numbersToPop = numbersToPush;
            }

            for (int i = 0; i < numbersToPush; i++)
            {
                stackOfNumbers.Push(numbers[i]);
            }

            for (int i = 0; i < numbersToPop; i++)
            {
                stackOfNumbers.Pop();
            }

            if (stackOfNumbers.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stackOfNumbers.Contains(numberToSearch))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stackOfNumbers.Min());
            }
        }
    }
}
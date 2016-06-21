namespace _04.BasicQueueOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class BasicQueue
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

            Queue<int> queueOfNumbers = new Queue<int>();

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
                queueOfNumbers.Enqueue(numbers[i]);
            }

            for (int i = 0; i < numbersToPop; i++)
            {
                queueOfNumbers.Dequeue();
            }

            if (queueOfNumbers.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queueOfNumbers.Contains(numberToSearch))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queueOfNumbers.Min());
            }
        }
    }
}
namespace _03.PeriodicTable
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var inputLines = int.Parse(Console.ReadLine());

            var collection = new SortedSet<string>();

            for (int i = 0; i < inputLines; i++)
            {
                var input = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in input)
                {
                    collection.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ", collection));
        }
    }
}

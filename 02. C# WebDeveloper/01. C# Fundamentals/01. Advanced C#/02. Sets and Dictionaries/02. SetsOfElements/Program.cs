namespace _02.SetsOfElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions
                .RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            var n = input[0];
            var m = input[1];

            var collectionN = new HashSet<int>();
            var collectionM = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                collectionN.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < m; i++)
            {
                collectionM.Add(int.Parse(Console.ReadLine()));
            }

            collectionN.IntersectWith(collectionM);

            Console.WriteLine(string.Join(" ", collectionN));
        }
    }
}

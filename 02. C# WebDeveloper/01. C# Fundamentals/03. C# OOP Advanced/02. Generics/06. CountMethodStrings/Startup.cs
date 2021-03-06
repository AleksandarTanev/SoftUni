﻿namespace _06.CountMethodStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var collection = new List<string>();
            int nLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < nLines; i++)
            {
                var input = Console.ReadLine();
                collection.Add(input);
            }

            var valueToCompareTo = Console.ReadLine();

            Console.WriteLine(CountGreaterElements(collection, valueToCompareTo));
        }

        public static int CountGreaterElements<T>(List<T> collection, T element)
            where T : IComparable
        {
            int count = collection.Count(c => c.CompareTo(element) > 0);

            return count;
        }
    }
}

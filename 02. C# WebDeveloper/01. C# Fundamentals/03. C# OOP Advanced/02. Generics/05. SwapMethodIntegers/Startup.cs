namespace _05.SwapMethodIntegers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var collection = new List<int>();
            int nLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < nLines; i++)
            {
                var input = int.Parse(Console.ReadLine());
                collection.Add(input);
            }

            var indexes =
                Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Swap(collection, indexes[0], indexes[1]);

            foreach (var item in collection)
            {
                Console.WriteLine($"{item.GetType().FullName}: {item}");
            }
        }

        public static void Swap<T>(List<T> collection, int firstIndex, int secondIndex)
        {
            T temp = collection[firstIndex];
            collection[firstIndex] = collection[secondIndex];
            collection[secondIndex] = temp;
        }
    }
}

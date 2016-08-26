namespace _06.ReverseAndExclude
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int diviser = int.Parse(Console.ReadLine());

            Predicate<int> filter = n => n % diviser != 0;

            Func<int[], Predicate<int>, int[]> func = ReverseAndFilter;

            Action<int[]> print = c => Console.WriteLine(string.Join(" ", c));

            var result = func(input, filter);
            print(result);
        }

        public static int[] ReverseAndFilter(int[] collection, Predicate<int> filter)
        {
            List<int> output = new List<int>();

            for (int i = collection.Length - 1; i >= 0; i--)
            {
                if (filter(collection[i]))
                {
                    output.Add(collection[i]);
                }
            }

            return output.ToArray();
        }
    }
}

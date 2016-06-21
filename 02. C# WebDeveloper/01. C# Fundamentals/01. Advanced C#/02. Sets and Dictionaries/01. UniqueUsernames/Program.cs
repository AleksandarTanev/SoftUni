namespace _01.UniqueUsernames
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var inputLines = int.Parse(Console.ReadLine());
            var collection = new HashSet<string>();

            for (int i = 0; i < inputLines; i++)
            {
                collection.Add(Console.ReadLine());
            }

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}

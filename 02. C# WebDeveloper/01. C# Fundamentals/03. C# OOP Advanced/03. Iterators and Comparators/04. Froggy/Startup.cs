namespace _04.Froggy
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var stones = Console.ReadLine().Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var lake = new Lake(stones);

            var output = new List<int>();
            foreach (var stone in lake)
            {
                output.Add(stone);
            }

            Console.WriteLine(string.Join(", ", output));
        }
    }
}

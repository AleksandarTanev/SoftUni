namespace _02.Cubic_Rube
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            long cellsNotChanged = n * n * n;
            double sumOfAllValues = 0;

            string input = Console.ReadLine();
            while (input != "Analyze")
            {
                int[] tokens = input
                    .Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int x = tokens[0];
                int y = tokens[1];
                int z = tokens[2];
                double value = tokens[3];

                if (x >= 0 && y >= 0 && z >= 0 && x < n && y < n && z < n)
                {
                    if (value != 0)
                    {
                        sumOfAllValues += value;
                        cellsNotChanged--;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(sumOfAllValues);
            Console.WriteLine(cellsNotChanged);
        }
    }
}

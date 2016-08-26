namespace _09.ListOfPredicates
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int[] divisers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var allPredicates = divisers.Select(diviser => (Predicate<int>) (n => n % diviser == 0)).ToArray();

            List<int> output = new List<int>();
            bool isForOutput;
            for (int i = 1; i <= input; i++)
            {
                isForOutput = true;
                foreach (var predicate in allPredicates)
                {
                    if (!predicate(i))
                    {
                        isForOutput = false;
                        break;
                    }
                }

                if (isForOutput)
                {
                    output.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}

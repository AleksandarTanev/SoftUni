namespace _04.FindEvensOdds
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string condition = Console.ReadLine();

            Predicate<int> delegIsEven = n => n % 2 == 0;
            Predicate<string> delegPrint = s => s == "even";

            List<int> output = new List<int>();

            for (int i = input[0]; i <= input[1]; i++)
            {
                if (delegIsEven(i) && delegPrint(condition))
                {
                    output.Add(i);
                }
                else if (!delegIsEven(i) && !delegPrint(condition))
                {
                    output.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}

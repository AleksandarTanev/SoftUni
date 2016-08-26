namespace _03.CustomMinFunction
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Func<int[], int> func = FindSmallestNumber;

            Console.WriteLine(func(input));
        }

        private static int FindSmallestNumber(int[] collection)
        {
            int min = Int32.MaxValue;
            
            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] < min)
                {
                    min = collection[i];
                }
            }

            return min;
        }
    }
}

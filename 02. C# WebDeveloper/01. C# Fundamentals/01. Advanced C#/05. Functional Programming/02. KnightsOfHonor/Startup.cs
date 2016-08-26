namespace _02.KnightsOfHonor
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> printOnConsole = AppendSir;
            printOnConsole += PrintOnConsole;

            printOnConsole(input);
        }

        private static void AppendSir(string[] collection)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                collection[i] = "Sir " + collection[i];
            }
        }

        private static void PrintOnConsole(string[] collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}

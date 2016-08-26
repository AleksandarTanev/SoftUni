namespace _01.ActionPrint
{
    using System;
    using System.Collections;

    public class Startup
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            Action<IEnumerable> printOnConsole = PrintOnConsole;

            printOnConsole(input);
        }

        private static void PrintOnConsole(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}

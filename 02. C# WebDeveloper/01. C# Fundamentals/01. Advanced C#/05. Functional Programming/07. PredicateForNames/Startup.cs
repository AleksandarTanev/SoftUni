namespace _07.PredicateForNames
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int condition = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Predicate<string> filter = n => n.Length <= condition;
            Action<string[], Predicate<string>> print = Print;

            print(input, filter);
        }

        public static void Print(string[] collection, Predicate<string> filter)
        {
            foreach (var name in collection)
            {
                if (filter(name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
namespace _04.CountSymbols
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var alphabet = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!alphabet.ContainsKey(input[i]))
                {
                    alphabet[input[i]] = 0;
                }

                alphabet[input[i]]++;
            }

            foreach (var item in alphabet)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}

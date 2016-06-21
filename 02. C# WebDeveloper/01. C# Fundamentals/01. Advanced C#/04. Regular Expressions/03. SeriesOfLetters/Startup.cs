namespace _03.SeriesOfLetters
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            HashSet<char> uniqueValues = new HashSet<char>();

            uniqueValues.UnionWith(input.ToCharArray());
            Regex pattern;
            string replacement;

            foreach (var item in uniqueValues)
            {
                replacement = string.Format("[{0}]+", item);
                pattern = new Regex(replacement);
                input = pattern.Replace(input, item.ToString());
            }

            Console.WriteLine(input);
        }
    }
}

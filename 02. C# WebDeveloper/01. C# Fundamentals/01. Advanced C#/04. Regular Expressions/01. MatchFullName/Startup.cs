namespace _01.MatchFullName
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Startup
    {
        public static void Main(string[] args)
        {
            HashSet<string> validNames = new HashSet<string>();
            Regex pattern = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            string input = Console.ReadLine();
            while (input != "end")
            {
                if (pattern.IsMatch(input))
                {
                    validNames.Add(input);
                }

                input = Console.ReadLine();
            }

            foreach (var name in validNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}

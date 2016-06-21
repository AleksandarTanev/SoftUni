namespace _02.MatchPhoneNumber
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Startup
    {
        public static void Main(string[] args)
        {
            HashSet<string> validNumbers = new HashSet<string>();
            Regex pattern = new Regex(@"\+359(-| )2\1\d{3}\1\d{4}\b");

            string input = Console.ReadLine();
            while (input != "end")
            {
                if (pattern.IsMatch(input))
                {
                    validNumbers.Add(input);
                }

                input = Console.ReadLine();
            }

            foreach (var number in validNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}


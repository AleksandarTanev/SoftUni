namespace _07.ValidUsernames
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"\b[a-zA-Z]\w{2,24}\b");
            MatchCollection matches = pattern.Matches(input);

            List<string> matchingWords = new List<string>();
            foreach (Match item in matches)
            {
                matchingWords.Add(item.ToString());
            }

            int maxSum = int.MinValue;
            int index = -1;

            for (int i = 0; i < matchingWords.Count - 1; i++)
            {
                if (maxSum < matchingWords[i].Length + matchingWords[i + 1].Length)
                {
                    maxSum = matchingWords[i].Length + matchingWords[i + 1].Length;
                    index = i;
                }
            }

            if (index != -1)
            {
                Console.WriteLine(matchingWords[index]);
                Console.WriteLine(matchingWords[index + 1]);
            }
            else
            {
                Console.WriteLine("No matches found.");
            }
        }
    }
}

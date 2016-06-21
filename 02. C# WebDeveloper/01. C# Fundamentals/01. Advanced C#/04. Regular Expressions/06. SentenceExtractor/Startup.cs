namespace _06.SentenceExtractor
{
    using System;
    using System.Text.RegularExpressions;

    public class Startup
    {
        public static void Main()
        {
            string wordToFind = Console.ReadLine();
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"(\w[^.!?]*)?\b" + wordToFind + @"\b[^.!?]*[.!?]");
            MatchCollection matches = pattern.Matches(input);

            foreach (Match item in matches)
            {
                Console.WriteLine(item);
            }
        }
    }
}
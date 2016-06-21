namespace _08.ExtractHyperlinks
{
    using System;
    using System.Text.RegularExpressions;

    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string inputcode = "";
            while (input != "END")
            {
                inputcode = inputcode + input + "\n";
                input = Console.ReadLine();
            }

            Regex pattern = new Regex("<a[^>]*href\\s*=\\s*(\\\"(?<first>[^\"]+)\\\"|'(?<second>[^']*)'|(?<third>[^'\">\\s]+))[^>]*>", RegexOptions.IgnoreCase);
            MatchCollection allMatches = pattern.Matches(inputcode);

            foreach (Match match in allMatches)
            {
                if (match.Groups["first"].ToString() != "")
                {
                    Console.WriteLine(match.Groups["first"]);
                }
                else if (match.Groups["second"].ToString() != "")
                {
                    Console.WriteLine(match.Groups["second"]);
                }
                else if (match.Groups["third"].ToString() != "")
                {
                    Console.WriteLine(match.Groups["third"]);
                }
            }
        }
    }
}

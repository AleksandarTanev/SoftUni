namespace _04.ReplaceATag
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<string> inputRows = new List<string>();

            while (input != "end")
            {
                inputRows.Add(input);
                input = Console.ReadLine();
            }

            Console.WriteLine();
            Regex pattern = new Regex(@"<a\s?href=(.)(\S*)(\1)>([^<]*)</a>");
            string output;
            foreach (var item in inputRows)
            {
                output = pattern.Replace(item, "[URL href=$1$2$1]$4[/URL]");
                Console.WriteLine(output);
            }

        }
    }
}

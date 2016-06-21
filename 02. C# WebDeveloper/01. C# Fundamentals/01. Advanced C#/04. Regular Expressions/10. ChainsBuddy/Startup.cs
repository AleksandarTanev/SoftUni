namespace _10.ChainsBuddy
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.Text;

    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Regex patternExtractText = new Regex(@"<p>(.+?)<\/p>");
            MatchCollection texts = patternExtractText.Matches(input);
            var outputs = new List<string>();

            foreach (Match match in texts)
            {
                string text = match.Groups[1].ToString();
                text = Regex.Replace(text, @"[^a-z0-9]+", " ");
                text = Regex.Replace(text, @"[ ]+", " ");

                StringBuilder textForFormat = new StringBuilder(text);
                for (int i = 0; i < textForFormat.Length; i++)
                {
                    int numValue = (int) textForFormat[i];

                    if (numValue >= 97 && numValue <= 109)
                    {
                        numValue += 13;
                    }
                    else if (numValue >= 110 && numValue <= 122)
                    {
                        numValue -= 13;
                    }

                    textForFormat[i] = (char) numValue;
                }

                outputs.Add(textForFormat.ToString());
            }

            Console.WriteLine(string.Join("", outputs));
        }
    }
}

namespace _09.QueryMess
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            Regex pattern = new Regex("([^&=]*)=([^&=]*)");

            string input = Console.ReadLine();
            while (input != "END")
            {
                MatchCollection matches = pattern.Matches(input);
                Dictionary<string, List<string>> allValues = new Dictionary<string, List<string>>();

                foreach (Match match in matches)
                {
                    string key = match.Groups[1].ToString();
                    key = key.Replace("+", " ").Replace("%20"," ").Trim();

                    if (key.Contains("?"))
                    {
                        key = key.Substring(key.LastIndexOf("?") + 1);
                    }

                    if (!allValues.ContainsKey(key))
                    {
                        allValues[key] = new List<string>();
                    }

                    string value = match.Groups[2].ToString();
                    value = value.Replace("%20", "+");
                    value = Regex.Replace(value, "[+]+", " ");
                    allValues[key].Add(value.Trim());
                }

                foreach (var pair in allValues)
                {
                    Console.Write($"{pair.Key}=[{string.Join(", ", pair.Value)}]");
                }
                Console.WriteLine();
                input = Console.ReadLine();
            }
        }
    }
}

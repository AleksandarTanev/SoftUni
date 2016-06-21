namespace _05.ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"\s[a-zA-Z0-9]{1}[\w-.]*[a-zA-Z0-9]{1}@[a-zA-Z0-9]{1}[\w-]*[.]{1}[\w-.]*[a-zA-Z0-9]{1}");
            MatchCollection matches = pattern.Matches(input);

            HashSet<string> emails = new HashSet<string>();
            foreach (Match item in matches)
            {
                emails.Add(item.ToString());
            }

            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}

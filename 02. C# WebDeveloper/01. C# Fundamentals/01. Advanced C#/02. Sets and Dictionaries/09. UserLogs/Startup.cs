namespace _09.UserLogs
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var users = new SortedDictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                var splittedInput = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                var user = splittedInput[2].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                if (!users.ContainsKey(user[1]))
                {
                    users[user[1]] = new Dictionary<string, int>();
                }

                var ip = splittedInput[0].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                if (!users[user[1]].ContainsKey(ip[1]))
                {
                    users[user[1]][ip[1]] = 0;
                }

                users[user[1]][ip[1]]++;

                input = Console.ReadLine();
            }

            foreach (var user in users)
            {
                Console.WriteLine(user.Key + ":");

                string output = "";
                foreach (var ip in user.Value)
                {
                    output += $"{ip.Key} => {ip.Value}, ";
                }

                output = output.Substring(0, output.Length - 2) + ".";
                Console.WriteLine(output);
            }
        }
    }
}

namespace _11.LogsAggregator
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var userIPs = new SortedDictionary<string, SortedSet<string>>();
            var userDuration = new Dictionary<string, long>();

            int numOfInputes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfInputes; i++)
            {
                var splittedInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string ip = splittedInput[0];
                string user = splittedInput[1];
                int duration = int.Parse(splittedInput[2]);

                if (!userIPs.ContainsKey(user))
                {
                    userIPs[user] = new SortedSet<string>();
                    userDuration[user] = 0;
                }

                userDuration[user] += duration;
                userIPs[user].Add(ip);
            }
            
            foreach (var user in userIPs)
            {
                Console.WriteLine($"{user.Key}: {userDuration[user.Key]} [{string.Join(", ", userIPs[user.Key])}]");
            }
        }
    }
}

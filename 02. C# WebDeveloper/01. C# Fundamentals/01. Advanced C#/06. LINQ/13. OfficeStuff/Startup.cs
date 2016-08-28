namespace _13.OfficeStuff
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var companies = new SortedDictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine().Replace("|", "");
                var tokens =
                    input.Split(new char[] {'-'}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => s.Trim())
                    .ToList();

                string company = tokens[0];
                int amount = int.Parse(tokens[1]);
                string product = tokens[2];

                if (!companies.ContainsKey(company))
                {
                    companies[company] = new Dictionary<string, int>();
                }

                if (!companies[company].ContainsKey(product))
                {
                    companies[company][product] = 0;
                }

                companies[company][product] += amount;
            }

            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Key}: {string.Join(", ", company.Value.Select(s => s.Key + "-" + s.Value).ToList())}");
            }
        }
    }
}

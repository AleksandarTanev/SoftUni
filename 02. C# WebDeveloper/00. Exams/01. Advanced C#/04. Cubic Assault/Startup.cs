namespace _04.Cubic_Assault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var regionMeteors = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();
            while (input != "Count em all")
            {
                string[] tokens = input.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);

                string region = tokens[0].Trim();
                string meteorType = tokens[1].Trim();
                long meteorCount = long.Parse(tokens[2].Trim());

                if (!regionMeteors.ContainsKey(region))
                {
                    regionMeteors[region] = new Dictionary<string, long>();
                }

                if (!regionMeteors[region].ContainsKey(meteorType))
                {
                    regionMeteors[region]["Green"] = 0;
                    regionMeteors[region]["Red"] = 0;
                    regionMeteors[region]["Black"] = 0;
                }

                regionMeteors[region][meteorType] += meteorCount;

                if (regionMeteors[region]["Green"] >= 1000000)
                {
                    regionMeteors[region]["Red"] += regionMeteors[region]["Green"] / 1000000;
                    regionMeteors[region]["Green"] = regionMeteors[region]["Green"] % 1000000;
                }

                if (regionMeteors[region]["Red"] >= 1000000)
                {
                    regionMeteors[region]["Black"] += regionMeteors[region]["Red"] / 1000000; ;
                    regionMeteors[region]["Red"] = regionMeteors[region]["Red"] % 1000000;
                }

                input = Console.ReadLine();
            }

            var sortedDictionary = regionMeteors
                .OrderByDescending(r => r.Value["Black"])
                .ThenBy(r => r.Key.Length)
                .ThenBy(r => r.Key)
                .Select(r => r.Key)
                .ToArray();

            for (int i = 0; i < sortedDictionary.Length; i++)
            {
                Console.WriteLine(sortedDictionary[i]);
                var sortedTypes = regionMeteors[sortedDictionary[i]]
                    .OrderByDescending(m => m.Value)
                    .ThenBy(m => m.Key)
                    .Select(m => m.Key)
                    .ToArray();

                for (int j = 0; j < sortedTypes.Length; j++)
                {
                    Console.WriteLine($"-> {sortedTypes[j]} : {regionMeteors[sortedDictionary[i]][sortedTypes[j]]}");
                }
            }
        }
    }
}

namespace _13.SrybskoUnleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Srabsko
    {
        static void Main()
        {
            List<string> inputList = new List<string>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                inputList.Add(input);
                input = Console.ReadLine();
            }

            Dictionary<string, Dictionary<string, long>> outputDictionary = new Dictionary<string, Dictionary<string, long>>();

            Regex pattern = new Regex(@"(.*) @(\w[ A-Za-z]* )(\d*) (\d*)");

            foreach (var item in inputList)
            {

                if (pattern.IsMatch(item))
                {
                    Match m = pattern.Match(item);

                    string venue = m.Groups[2].Value;
                    string singer = m.Groups[1].Value;
                    int ticketPrice = int.Parse(m.Groups[3].Value);
                    int ticketCount = int.Parse(m.Groups[4].Value);


                    if (!outputDictionary.ContainsKey(venue))
                    {
                        outputDictionary.Add(venue, new Dictionary<string, long>());
                    }

                    if (!outputDictionary[venue].ContainsKey(singer))
                    {
                        outputDictionary[venue].Add(singer, 0);
                    }

                    outputDictionary[venue][singer] += ticketPrice * ticketCount;
                }
            }

            foreach (var venue in outputDictionary)
            {
                Console.WriteLine(venue.Key);
                var sorting = venue.Value.OrderByDescending(s => s.Value);
                foreach (var singer in sorting)
                {
                    Console.WriteLine("#  {0} -> {1}", singer.Key, singer.Value);
                }
            }
        }
    }
}

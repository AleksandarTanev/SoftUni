namespace _10.PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var countries = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (input != "report")
            {
                var splittedInput = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                string country = splittedInput[1];
                string city = splittedInput[0];
                int population = int.Parse(splittedInput[2]);

                if (!countries.ContainsKey(country))
                {
                    countries[country] = new Dictionary<string, long>();
                }

                if (!countries[country].ContainsKey(city))
                {
                    countries[country][city] = population;
                }
                else
                {
                    countries[country][city] += population;
                }

                input = Console.ReadLine();
            }
        
            
            List<string> sortedCountries = countries
                .OrderByDescending(x => x.Value.Sum(v => v.Value))
                .Select(kp => kp.Key)
                .ToList();
            
            foreach (var country in sortedCountries)
            {
                long populationSum = countries[country].Sum(x => x.Value);
                Console.WriteLine($"{country} (total population: {populationSum})");

                List<string> orderedCities = countries[country].OrderByDescending(kp => kp.Value)
                                      .Select(kp => kp.Key)
                                      .ToList();

                foreach (var city in orderedCities)
                {
                    Console.WriteLine($"=>{city}: {countries[country][city]}");
                }
            }
        }
    }
}

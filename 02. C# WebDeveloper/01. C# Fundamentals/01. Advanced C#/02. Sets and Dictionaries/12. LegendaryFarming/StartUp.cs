namespace _12.LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            string legendaryItem = "";
            var keyMaterials = new SortedDictionary<string, long>();
            var junkMaterials = new SortedDictionary<string, long>();

            keyMaterials["shards"] = 0;
            keyMaterials["motes"] = 0;
            keyMaterials["fragments"] = 0;

            bool legendaryNotFound = true;
            while (legendaryNotFound)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;

                        if (keyMaterials[material] >= 250)
                        {
                            if (material == "shards")
                            {
                                legendaryItem = "Shadowmourne";
                            }
                            else if (material == "motes")
                            {
                                legendaryItem = "Dragonwrath";
                            }
                            else if (material == "fragments")
                            {
                                legendaryItem = "Valanyr";
                            }

                            keyMaterials[material] -= 250;
                            legendaryNotFound = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = 0;
                        }

                        junkMaterials[material] += quantity;
                    }
                }
            }

            Console.WriteLine($"{legendaryItem} obtained!");

            var sortedKeyMaterials = keyMaterials
                .OrderByDescending(x => x.Value)
                .Select(kp => kp.Key)
                .ToList();

            foreach (var material in sortedKeyMaterials)
            {
                Console.WriteLine($"{material}: {keyMaterials[material]}");
            }

            foreach (var material in junkMaterials)
            {
                Console.WriteLine($"{material.Key}: {junkMaterials[material.Key]}");
            }
        }
    }
}

namespace _11.CustomAttribute
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using Attributes;
    using Enums;
    using Interfaces;
    using Models.Gems;
    using Models.Weapons;

    public class Startup
    {
        public static void Main()
        {
            var attribute = typeof(Weapon).GetCustomAttribute<InfoAttribute>(false);

            var weapons = new Dictionary<string, IWeapon>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                var tokens = input
                    .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(t => t.Trim())
                    .ToList();

                string command = tokens[0];

                switch (command)
                {
                    case "Create":
                        {
                            var additionalTokens = tokens[1].Split();

                            WeaponRarity weaponRarity = (WeaponRarity)Enum.Parse(typeof(WeaponRarity), additionalTokens[0]);
                            string weaponType = additionalTokens[1];
                            string weaponName = tokens[2];

                            if (weaponType == "Axe")
                            {
                                IWeapon newWeapon = new Axe(weaponName, weaponRarity);
                                weapons.Add(weaponName, newWeapon);
                            }
                            else if (weaponType == "Sword")
                            {
                                IWeapon newWeapon = new Sword(weaponName, weaponRarity);
                                weapons.Add(weaponName, newWeapon);
                            }
                            else if (weaponType == "Knife")
                            {
                                IWeapon newWeapon = new Knife(weaponName, weaponRarity);
                                weapons.Add(weaponName, newWeapon);
                            }

                            break;
                        }

                    case "Add":
                        {
                            string weaponName = tokens[1];
                            int gemIndex = int.Parse(tokens[2]);

                            var additionalTokens = tokens[3].Split();
                            GemQuality gemQuality = (GemQuality)Enum.Parse(typeof(GemQuality), additionalTokens[0]);
                            string gemType = additionalTokens[1];

                            IGem newGem = null;

                            if (gemType == "Ruby")
                            {
                                newGem = new Ruby(gemQuality);
                            }
                            else if (gemType == "Emerald")
                            {
                                newGem = new Emerald(gemQuality);
                            }
                            else if (gemType == "Amethyst")
                            {
                                newGem = new Amethyst(gemQuality);
                            }

                            if (weapons.ContainsKey(weaponName) && newGem != null)
                            {
                                weapons[weaponName].AddGem(newGem, gemIndex);
                            }

                            break;
                        }

                    case "Remove":
                        {
                            string weaponName = tokens[1];
                            int gemIndex = int.Parse(tokens[2]);

                            if (weapons.ContainsKey(weaponName))
                            {
                                weapons[weaponName].RemoveGem(gemIndex);
                            }

                            break;
                        }

                    case "Print":
                        {
                            string weaponName = tokens[1];

                            if (weapons.ContainsKey(weaponName))
                            {
                                Console.WriteLine(weapons[weaponName]);
                            }

                            break;

                        }
                    case "Author":
                        {
                            Console.WriteLine($"Author: {attribute.Author}");
                            break;
                        }

                    case "Revision":
                        {
                            Console.WriteLine($"Revision: {attribute.Revisions}");
                            break;
                        }

                    case "Description":
                        {
                            Console.WriteLine($"Class description: {attribute.Description}");
                            break;
                        }
                    case "Reviewers":
                        {
                            Console.WriteLine($"Reviewers: {string.Join(", ", attribute.Reviewers)}");
                            break;
                        }
                }

                input = Console.ReadLine();
            }
        }
    }
}
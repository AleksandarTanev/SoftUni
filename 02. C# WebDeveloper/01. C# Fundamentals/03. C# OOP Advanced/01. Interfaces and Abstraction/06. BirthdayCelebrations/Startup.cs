namespace _06.BirthdayCelebrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Interfaces;
    using Models;

    public class Startup
    {
        public static void Main()
        {
            var indentitiesWithBirthdays = new List<IBirthable>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                var tokens = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Citizen")
                {
                    string name = tokens[1];
                    int age = int.Parse(tokens[2]);
                    string id = tokens[3];
                    string birthday = tokens[4];

                    indentitiesWithBirthdays.Add(new Citizen(name, age, id, birthday));
                }
                else if (tokens[0] == "Pet")
                {
                    string name = tokens[1];
                    string birthday = tokens[2];

                    indentitiesWithBirthdays.Add(new Pet(name, birthday));
                }

                input = Console.ReadLine();
            }

            string pattern = Console.ReadLine();

            var extractedIndentities = indentitiesWithBirthdays.Where(i => i.Birthday.EndsWith(pattern));

            if (extractedIndentities.Count() != 0)
            {
                foreach (var extractedIndentity in extractedIndentities)
                {
                    Console.WriteLine(extractedIndentity.Birthday);
                }
            }
        }
    }
}

namespace _05.BorderControl
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
            var indentities = new List<IIdentifiable>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                var tokens = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 3)
                {
                    string name = tokens[0];
                    int age = int.Parse(tokens[1]);
                    string id = tokens[2];

                    indentities.Add(new Citizen(name, age, id));
                }
                else if (tokens.Length == 2)
                {
                    string model = tokens[0];
                    string id = tokens[1];

                    indentities.Add(new Robot(model, id));
                }

                input = Console.ReadLine();
            }

            string pattern = Console.ReadLine();

            var extractedIndentities = indentities.Where(i => i.CheckIdValidity(pattern));

            foreach (var extractedIndentity in extractedIndentities)
            {
                Console.WriteLine(extractedIndentity.Id);
            }
        }
    }
}

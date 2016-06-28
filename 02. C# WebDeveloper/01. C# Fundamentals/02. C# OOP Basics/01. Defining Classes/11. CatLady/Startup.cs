namespace _11.CatLady
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<Cat> cats = new List<Cat>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                var tokens = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                string type = tokens[0];
                string name = tokens[1];
                string value = tokens[2];

                if (type == "Siamese")
                {
                    cats.Add(new Siamese(name, int.Parse(value)));
                }
                else if (type == "Cymric")
                {
                    cats.Add(new Cymric(name, double.Parse(value)));
                }
                else if (type == "StreetExtraordinaire")
                {
                    cats.Add(new StreetExtraordinaire(name, int.Parse(value)));
                }

                input = Console.ReadLine();
            }

            string nameToSearch = Console.ReadLine();

            Console.WriteLine(cats.FirstOrDefault(c => c.name == nameToSearch).ToString());
        }
    }
}

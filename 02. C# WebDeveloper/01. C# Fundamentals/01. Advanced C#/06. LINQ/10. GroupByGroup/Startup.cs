namespace _10.GroupByGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();

            var input = Console.ReadLine();
            while (input != "END")
            {
                var tokens = input.Split();

                string name = tokens[0] + " " + tokens[1];
                int givenGroup = int.Parse(tokens[2]);

                people.Add(new Person(name, givenGroup));

                input = Console.ReadLine();
            }

            var groups = people.GroupBy(p => p.Group, p => p.Name).OrderBy(g => g.Key);

            foreach (var @group in groups)
            {
                Console.WriteLine(@group.Key + " - " + string.Join(", ", @group));
            }
        }
    }
}

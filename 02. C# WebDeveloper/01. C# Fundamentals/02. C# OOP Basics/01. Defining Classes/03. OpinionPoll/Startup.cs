namespace _03.OpinionPoll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[] {' '});
                people.Add(new Person(input[0], int.Parse(input[1])));
            }

            var output = people
                .Where(p => p.age > 30)
                .OrderBy(p => p.name)
                .ToList();

            foreach (var person in output)
            {
                Console.WriteLine($"{person.name} - {person.age}");
            }
        }
    }
}
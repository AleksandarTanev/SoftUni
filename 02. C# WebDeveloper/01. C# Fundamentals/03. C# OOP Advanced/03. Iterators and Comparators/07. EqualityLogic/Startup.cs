namespace _07.EqualityLogic
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var sortedPeople = new SortedSet<Person>();
            var hashPeople = new HashSet<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();

                var newPerson = new Person(tokens[0], int.Parse(tokens[1]));

                sortedPeople.Add(newPerson);
                hashPeople.Add(newPerson);
            }

            Console.WriteLine(sortedPeople.Count);
            Console.WriteLine(hashPeople.Count);
        }
    }
}

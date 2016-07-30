namespace _06.StrategyPattern
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var nameComparedPeople = new SortedSet<Person>(new Person.PersonByNameComparer());
            var ageComparedPeople = new SortedSet<Person>(new Person.PersonByAgeComparer());

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();
                
                var newPerson = new Person(tokens[0], int.Parse(tokens[1]));

                nameComparedPeople.Add(newPerson);
                ageComparedPeople.Add(newPerson);
            }

            foreach (var person in nameComparedPeople)
            {
                Console.WriteLine(person);
            }

            foreach (var person in ageComparedPeople)
            {
                Console.WriteLine(person);
            }
        }
    }
}

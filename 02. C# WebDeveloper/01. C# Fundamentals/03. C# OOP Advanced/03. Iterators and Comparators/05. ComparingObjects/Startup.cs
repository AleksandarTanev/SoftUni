using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ComparingObjects
{
    public class Startup
    {
        public static void Main()
        {
            var people = new List<Person>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                var tokens = input.Split();

                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];

                people.Add(new Person(name, age, town));

                input = Console.ReadLine();
            }

            int index = int.Parse(Console.ReadLine());
            

            if (index < 0 || index >= people.Count)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Person selectedPerson = people[index];

                int equalPeople = people.Count(p => p.CompareTo(selectedPerson) == 0);
                int notEqualPeople = people.Count(p => p.CompareTo(selectedPerson) != 0);
                int totalPeople = people.Count;

                Console.WriteLine($"{equalPeople} {notEqualPeople} {totalPeople}");
            }
        }
    }
}

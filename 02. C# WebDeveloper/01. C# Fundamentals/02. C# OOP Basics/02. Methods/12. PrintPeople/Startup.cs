namespace _12.PrintPeople
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var people = new List<Person>();

            string input = Console.ReadLine();
            while (input != "END")
            {
                var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string occupation = tokens[2];

                people.Add(new Person(name, age, occupation));

                input = Console.ReadLine();
            }

            people.Sort();

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}

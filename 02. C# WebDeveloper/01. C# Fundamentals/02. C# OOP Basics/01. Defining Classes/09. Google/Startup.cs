namespace _09.Google
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var people = new Dictionary<string, Person>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string personName = tokens[0];
                string inputType = tokens[1];

                if (!people.ContainsKey(personName))
                {
                    people.Add(personName, new Person(personName));
                }

                if (inputType == "company")
                {
                    string compName = tokens[2];
                    string compDep = tokens[3];
                    decimal compSalary = decimal.Parse(tokens[4]);

                    people[personName].company = new Company(compName, compDep, compSalary);
                }
                else if (inputType == "pokemon")
                {
                    string pokName = tokens[2];
                    string pokType = tokens[3];

                    people[personName].pokemons.Add(new Pokemon(pokName, pokType));
                }
                else if (inputType == "parents")
                {
                    string parName = tokens[2];
                    string parBirthday = tokens[3];

                    people[personName].parents.Add(new Parent(parName, parBirthday));
                }
                else if (inputType == "children")
                {
                    string chName = tokens[2];
                    string chBirthday = tokens[3];

                    people[personName].children.Add(new Child(chName, chBirthday));
                }
                else if (inputType == "car")
                {
                    string carModel = tokens[2];
                    int carSpeed = int.Parse(tokens[3]);

                    people[personName].car = new Car(carModel, carSpeed);
                }

                input = Console.ReadLine();
            }

            string person = Console.ReadLine();
            Console.WriteLine(people[person]);
        }
    }
}

namespace _10.ExplicitInterfaces
{
    using System;

    using Interfaces;
    using Models;

    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                string country = tokens[1];
                int age = int.Parse(tokens[2]);

                IPerson person = new Citizen(name, country, age);
                IResident resident = new Citizen(name, country, age);

                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());

                input = Console.ReadLine();
            }
        }
    }
}

namespace _05.AnimalClinic
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            List<Animal> healedAnimals = new List<Animal>();
            List<Animal> rehabilitatedAnimals = new List<Animal>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                string breed = tokens[1];
                string todo = tokens[2];

                var animal = new Animal(name, breed);

                if (todo == "heal")
                {
                    healedAnimals.Add(animal);
                    AnimalClinic.healedAnimalsCount++;

                    Console.WriteLine($"Patient {animal.id}: [{animal.name} ({animal.breed})] has been healed!");
                }
                else if (todo == "rehabilitate")
                {
                    rehabilitatedAnimals.Add(animal);
                    AnimalClinic.rehabilitedAnimalsCount++;

                    Console.WriteLine($"Patient {animal.id}: [{animal.name} ({animal.breed})] has been rehabilitated!");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total healed animals: {AnimalClinic.healedAnimalsCount}");
            Console.WriteLine($"Total rehabilitated animals: {AnimalClinic.rehabilitedAnimalsCount}");

            input = Console.ReadLine();

            if (input == "heal")
            {
                foreach (var animal in healedAnimals)
                {
                    Console.WriteLine(animal);
                }
            }
            else
            {
                foreach (var animal in rehabilitatedAnimals)
                {
                    Console.WriteLine(animal);
                }
            }
        }
    }
}

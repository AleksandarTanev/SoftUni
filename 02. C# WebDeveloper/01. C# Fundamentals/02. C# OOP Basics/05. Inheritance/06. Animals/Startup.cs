namespace _06.Animals
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "Beast!")
            {
                string animalType = input;

                var tokens = Console.ReadLine().Split(new char[] { ' ' });

                string name = tokens[0].Trim();
                int age = int.Parse(tokens[1].Trim());

                Animal animal = null;

                try
                {
                    if (animalType == "Dog")
                    {
                        string gender = tokens[2];
                        animal = new Dog(name, age, gender);
                    }
                    else if (animalType == "Cat")
                    {
                        string gender = tokens[2];
                        animal = new Cat(name, age, gender);
                    }
                    else if (animalType == "Frog")
                    {
                        string gender = tokens[2];
                        animal = new Frog(name, age, gender);
                    }
                    else if (animalType == "Kitten")
                    {
                        animal = new Kitten(name, age);
                    }
                    else if (animalType == "Tomcat")
                    {
                        animal = new Tomcat(name, age);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }

                    if (animal != null)
                    {
                        Console.WriteLine(animalType);
                        Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                        animal.ProduceSound();
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }

                input = Console.ReadLine();
            }
        }
    }
}

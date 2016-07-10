namespace _03.WildFarm
{
    using Foods;
    using Animals;
    using System;

    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string type = tokens[0];
                string name = tokens[1];
                double weight = double.Parse(tokens[2]);
                string region = tokens[3];
                string breed = "";

                if (type == "Cat")
                {
                   breed = tokens[4];
                }

                Mammal animal;
                if (type == "Mouse")
                {
                    animal = new Mouse(name, type, weight, region);
                }
                else if (type == "Tiger")
                {
                    animal = new Tiger(name, type, weight, region);
                }
                else if (type == "Cat")
                {
                    animal = new Cat(name, type, weight, region, breed);
                }
                else
                {
                    animal = new Zebra(name, type, weight, region);
                }

                input = Console.ReadLine();
                tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string foodType = tokens[0];
                int foodQuantity = int.Parse(tokens[1]);

                Food food;
                if (foodType == "Vegetable")
                {
                    food = new Vegetable(foodQuantity);
                }
                else
                {
                    food = new Meat(foodQuantity);
                }


                animal.MakeSound();
                animal.Eat(food);
                
                Console.WriteLine(animal);

                input = Console.ReadLine();
            }
        }
    }
}

namespace _05.CreatePizza
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            Pizza pizza = null;
            Dough dough = null;
            List<Topping> toppings = new List<Topping>();

            try
            {
                string input = Console.ReadLine();

                while (input != "END")
                {
                    var tokens = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    string inputType = tokens[0];
                    if (inputType == "Pizza")
                    {
                        string pizzaName = tokens[1];
                        int toppingsNumber = int.Parse(tokens[2]);

                        pizza = new Pizza(pizzaName, toppingsNumber);
                    }
                    else if (inputType == "Dough")
                    {
                        string flourType = tokens[1];
                        string bakingTech = tokens[2];
                        double weight = double.Parse(tokens[3]);

                        dough = new Dough(flourType, bakingTech, weight);

                        if (pizza == null)
                        {
                            Console.WriteLine($"{dough.GetCalories():F2}");

                        }
                    }
                    else if (inputType == "Topping")
                    {
                        string type = tokens[1];
                        double weight = double.Parse(tokens[2]);

                        var topping = new Topping(type, weight);
                        toppings.Add(topping);

                    }

                    input = Console.ReadLine();
                }

                if (pizza != null && dough != null && toppings.Count == pizza.NumOfToppings)
                {
                    pizza.SetDough(dough);
                    foreach (var topping in toppings)
                    {
                        pizza.AddNewTopping(topping);
                    }

                    Console.WriteLine($"{pizza.Name} - {pizza.GetCalories():F2} Calories.");
                }
                else if (pizza == null && toppings.Count > 0 )
                {
                    double callories = 0;

                    foreach (var topping in toppings)
                    {
                        callories += topping.GetCalories();
                    }

                    Console.WriteLine($"{callories:F2}");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

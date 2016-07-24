namespace _07.FoodShortage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Interfaces;
    using Models;

    public class Startup
    {
        public static void Main()
        {
            var buyers = new Dictionary<string, IBuyer>();

            int n = int.Parse(Console.ReadLine());

            string input;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                var tokens = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 4)
                {
                    string name = tokens[0];
                    int age = int.Parse(tokens[1]);
                    string id = tokens[2];
                    string birthday = tokens[3];

                    buyers.Add(name, new Citizen(name, age, id, birthday));
                }
                else if (tokens.Length == 3)
                {
                    string name = tokens[0];
                    int age = int.Parse(tokens[1]);
                    string group = tokens[2];

                    buyers.Add(name, new Rebel(name, age, group));
                }
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                if (buyers.ContainsKey(input))
                {
                    buyers[input].BuyFood();
                }

                input = Console.ReadLine();
            }

            int totalFood = buyers.Sum(b => b.Value.Food);
            Console.WriteLine(totalFood);
        }
    }
}

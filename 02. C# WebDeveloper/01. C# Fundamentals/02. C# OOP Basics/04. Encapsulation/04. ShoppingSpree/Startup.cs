namespace _04.ShoppingSpree
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var people = new Dictionary<string, Person>();
            var products = new Dictionary<string, Product>();

            string input = Console.ReadLine();
            var tokens = input.Split(new char[] {';'});
            foreach (var token in tokens)
            {
                var s = token.Split(new char[] { '=' });

                string name = s[0].Trim();
                double money = double.Parse(s[1].Trim());

                try
                {
                    people.Add(name, new Person(name, money));
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            input = Console.ReadLine();
            tokens = input.Split(new char[] { ';' });
            foreach (var token in tokens)
            {
                var s = token.Split(new char[] { '=' });

                string name = s[0].Trim();
                double cost = double.Parse(s[1].Trim());

                try
                {
                    products.Add(name, new Product(name, cost));
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            input = Console.ReadLine();
            while (input != "END")
            {
                tokens = input.Split(new char[] { ' ' });

                string namePerson = tokens[0];
                string nameProduct = tokens[1];

                people[namePerson].AddProductToBag(products[nameProduct]);

                input = Console.ReadLine();
            }

            foreach (var person in people)
            {
                if (person.Value.Bag.Count == 0)
                {
                    Console.WriteLine($"{person.Key} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Key} - {string.Join(", ", person.Value.Bag)}");
                }
            }
        }
    }
}

namespace _09.PizzaTime
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Pizza
    {
        public string name;
        public int group;

        public Pizza(string name, int group)
        {
            this.name = name;
            this.group = group;
        }

        public static SortedDictionary<int, List<string>> GetGroupedPizzas(params string[] pizzas)
        {
            List<Pizza> listOfPizza = new List<Pizza>();
            Regex pattern = new Regex(@"(\d+)(\w+)");
            foreach (var pizza in pizzas)
            {
                Match match = pattern.Match(pizza);
                listOfPizza.Add(new Pizza(match.Groups[2].ToString(), int.Parse(match.Groups[1].ToString())));
            }

            var outDict = new SortedDictionary<int, List<string>>();

            foreach (var pizza in listOfPizza)
            {
                if (!outDict.ContainsKey(pizza.group))
                {
                    outDict[pizza.group] = new List<string>();
                }

                outDict[pizza.group].Add(pizza.name);
            }

            return outDict;
        }
    }
}

namespace _10.PredicateParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();


            string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "Party!")
            {
                Predicate<string> filter = n => true;

                string condition = command[0];
                string comm = command[1];
                string criteria = command[2];

                if (comm == "StartsWith")
                {
                    filter = n => n.StartsWith(criteria);
                }
                else if (comm == "Length")
                {
                    filter = n => n.Length == int.Parse(criteria);
                }
                else if (comm == "EndsWith")
                {
                    filter = n => n.EndsWith(criteria);
                }

                if (condition == "Remove")
                {
                    DonditionRemove(input, filter);
                }
                else if (condition == "Double")
                {
                    DonditionDouble(input, filter);
                }

                command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            if (input.Count != 0)
            {
                Console.WriteLine(string.Join(", ", input) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        public static void DonditionDouble(List<string> collection, Predicate<string> filter)
        {
            List<string> newList = new List<string>();
            for (int i = 0; i < collection.Count; i++)
            {
                if (filter(collection[i]))
                {
                    newList.Add(collection[i]);
                    newList.Add(collection[i]);
                }
                else
                {
                    newList.Add(collection[i]);
                }
            }

            collection.Clear();
            foreach (var item in newList)
            {
                collection.Add(item);
            }
        }

        public static void DonditionRemove(List<string> collection, Predicate<string> filter)
        {
            List<string> newList = new List<string>();
            for (int i = 0; i < collection.Count; i++)
            {
                if (!filter(collection[i]))
                {
                    newList.Add(collection[i]);
                }
            }

            collection.Clear();
            foreach (var item in newList)
            {
                collection.Add(item);
            }
        }
    }
}

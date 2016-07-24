namespace _09.CollectionHierarchy
{
    using System;
    using System.Collections.Generic;
    using Models;

    public class Startup
    {
        public static void Main()
        {
            var addCollection = new AddCollection();
            var addRemoveCollection = new AddRemoveCollection();
            var myList = new MyList();

            var inputStrings = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var displayIntList = new List<int>();
            foreach (var inputString in inputStrings)
            {
                displayIntList.Add(addCollection.Add(inputString));
            }
            Console.WriteLine(string.Join(" ", displayIntList));

            displayIntList.Clear();
            foreach (var inputString in inputStrings)
            {
                displayIntList.Add(addRemoveCollection.Add(inputString));
            }
            Console.WriteLine(string.Join(" ", displayIntList));

            displayIntList.Clear();
            foreach (var inputString in inputStrings)
            {
                displayIntList.Add(myList.Add(inputString));
            }
            Console.WriteLine(string.Join(" ", displayIntList));

            int n = int.Parse(Console.ReadLine());

            var displayStringList = new List<string>();
            for (int i = 0; i < n; i++)
            {
                displayStringList.Add(addRemoveCollection.Remove());
            }
            Console.WriteLine(string.Join(" ", displayStringList));

            displayStringList.Clear();
            for (int i = 0; i < n; i++)
            {
                displayStringList.Add(myList.Remove());
            }
            Console.WriteLine(string.Join(" ", displayStringList));
        }
    }
}

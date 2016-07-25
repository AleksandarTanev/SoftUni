namespace _10.CustomListIterator.IO
{
    using System;

    using Models;
    using Sorters;

    public class CommandInterpreter
    {
        private CustomList<string> collection;

        public CommandInterpreter(CustomList<string> collection)
        {
            this.collection = collection;
        }

        public void InterpretCommand(string[] tokens)
        {
            string command = tokens[0];

            string element;
            switch (command)
            {
                case "Add":
                    element = tokens[1];
                    collection.Add(element);
                    break;
                case "Remove":
                    int index = int.Parse(tokens[1]);
                    collection.Remove(index);
                    break;
                case "Contains":
                    element = tokens[1];
                    Console.WriteLine(collection.Contains(element));
                    break;
                case "Swap":
                    int index1 = int.Parse(tokens[1]);
                    int index2 = int.Parse(tokens[2]);
                    collection.Swap(index1, index2);
                    break;
                case "Greater":
                    element = tokens[1];
                    Console.WriteLine(collection.CountGreaterThan(element));
                    break;
                case "Max":
                    Console.WriteLine(collection.Max());
                    break;
                case "Min":
                    Console.WriteLine(collection.Min());
                    break;
                case "Print":
                    collection.Print();
                    break;
                case "Sort":
                    Sorter.Sort(collection);
                    break;
                default:
                    break;
            }
        }
    }
}

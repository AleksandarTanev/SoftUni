namespace _05.Phonebook
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var phonebook = new SortedDictionary<string, string>();

            string input = Console.ReadLine();
            while (input != "stop" && input != "search")
            {
                var inputArray = input.Split(new char[] {'-'}, StringSplitOptions.RemoveEmptyEntries);

                phonebook[inputArray[0]] = inputArray[1];
                
                input = Console.ReadLine();
            }

            if (input != "stop")
            {
                input = Console.ReadLine();
                while (input != "stop")
                {
                    if (phonebook.ContainsKey(input))
                    {
                        Console.WriteLine($"{input} -> { phonebook[input]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input} does not exist.");
                    }

                    input = Console.ReadLine();
                }
            }
        }
    }
}

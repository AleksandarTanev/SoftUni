namespace _07.FixEmails
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var emailBook = new Dictionary<string, string>();

            string input = Console.ReadLine();
            while (input != "stop")
            {
                if (!emailBook.ContainsKey(input))
                {
                    emailBook[input] = "";
                }

                string email = Console.ReadLine();
                emailBook[input] = email;

                input = Console.ReadLine();
            }

            var peopleToRemove = new HashSet<string>();
            foreach (var item in emailBook)
            {
                if (item.Value.Contains(".uk") || item.Value.Contains(".us"))
                {
                    peopleToRemove.Add(item.Key);
                }
            }

            foreach (var person in peopleToRemove)
            {
                emailBook.Remove(person);
            }

            foreach (var item in emailBook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

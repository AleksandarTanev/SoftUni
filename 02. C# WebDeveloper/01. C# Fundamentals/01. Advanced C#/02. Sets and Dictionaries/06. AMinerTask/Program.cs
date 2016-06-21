namespace _06.AMinerTask
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var recourses = new Dictionary<string, long>();

            string input = Console.ReadLine();
            while (input != "stop")
            {
                if (!recourses.ContainsKey(input))
                {
                    recourses[input] = 0;
                }

                long recourse = long.Parse(Console.ReadLine());
                recourses[input] += recourse;

                input = Console.ReadLine();
            }

            foreach (var item in recourses)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

namespace _09.StudentsEnrolled
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<string[]> listOfStudents = new List<string[]>();

            string input = Console.ReadLine();
            while (input != "END")
            {
                listOfStudents
                    .Add(input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray());

                input = Console.ReadLine();
            }

            var output = listOfStudents
                .Where(s => s[0].EndsWith("14") || s[0].EndsWith("15"))
                .ToArray();

            foreach (var student in output)
            {
                Console.WriteLine(string.Join(" ", student.Skip(1)));
            }
        }
    }
}

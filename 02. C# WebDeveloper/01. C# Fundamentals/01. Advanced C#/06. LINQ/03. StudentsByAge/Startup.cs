namespace _03.StudentsByAge
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
                listOfStudents.Add(input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray());

                input = Console.ReadLine();
            }

            var output = listOfStudents.Where(s => int.Parse(s[2]) >= 18 && int.Parse(s[2]) <= 24).ToArray();
            foreach (var student in output)
            {
                Console.WriteLine(student[0] + " " + student[1] + " " + student[2]);
            }
        }
    }
}

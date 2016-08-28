namespace _02.StudentsFLName
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

            var output = listOfStudents.Where(s => s[0].CompareTo(s[1]) < 0).ToArray();
            foreach (var student in output)
            {
                Console.WriteLine(student[0] + " " + student[1]);
            }
        }
    }
}

namespace _02.UniqueNames
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            while (input != "End")
            {
                StudentGroup.students.Add(new Student(input));

                input = Console.ReadLine();
            }

            Console.WriteLine(StudentGroup.students.Count);
        }
    }
}

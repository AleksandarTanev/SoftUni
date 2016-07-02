namespace _01.Students
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var students = new List<Student>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                students.Add(new Student(input));

                input = Console.ReadLine();
            }

            Console.WriteLine(Student.coutStudents);
        }
    }
}

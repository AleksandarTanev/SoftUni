namespace _11.StudentsJoinedSpecialties
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<StudentSpecialty> studentSpecialties = new List<StudentSpecialty>();
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();
            while (input != "Students:")
            {
                var tokens = input.Split();

                string name = tokens[0] + " " + tokens[1];
                string facNumber = tokens[2];

                studentSpecialties.Add(new StudentSpecialty(name, facNumber));

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "END")
            {
                var tokens = input.Split();

                string facNumber = tokens[0];
                string name = tokens[1] + " " + tokens[2];

                students.Add(new Student(name, facNumber));

                input = Console.ReadLine();
            }

            var combinedList = studentSpecialties
                .Join(students,
                    a => a.facultyNumber,
                    m => m.facultyNumber,
                    (a, m) => new {a.specialtyName, m.studentName, a.facultyNumber})
                .OrderBy(p => p.studentName);

            foreach (var element in combinedList)
            {
                Console.WriteLine($"{element.studentName} {element.facultyNumber} {element.specialtyName}");
            }
        }
    }
}

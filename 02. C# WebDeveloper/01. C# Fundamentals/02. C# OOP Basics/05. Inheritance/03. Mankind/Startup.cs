namespace _03.Mankind
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Startup
    {
        public static void Main()
        {
            var tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string stFirstName = tokens[0];
            string stLastName = tokens[1];
            string stFacNumber = tokens[2];

            tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string wFirstName = tokens[0];
            string wLastName = tokens[1];
            double wWeekSalary = double.Parse(tokens[2]);
            double wWorkHours = double.Parse(tokens[3]);

            try
            {
                var student = new Student(stFirstName, stLastName, stFacNumber);
                var worker = new Worker(wFirstName, wLastName, wWeekSalary, wWorkHours);

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

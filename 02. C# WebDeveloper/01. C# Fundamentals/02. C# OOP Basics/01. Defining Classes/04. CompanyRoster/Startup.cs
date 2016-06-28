namespace _04.CompanyRoster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (input.Length == 4)
                {
                    employees.Add(new Employee(input[0], double.Parse(input[1]), input[2], input[3]));
                }
                else if (input.Length == 5)
                {
                    if (input[4].Contains("@") == true)
                    {
                        employees.Add(new Employee(input[0], double.Parse(input[1]), input[2], input[3], input[4]));
                    }
                    else
                    {
                        employees.Add(new Employee(input[0], double.Parse(input[1]), input[2], input[3], int.Parse(input[4])));
                    }
                }
                else
                {
                    employees.Add(new Employee(input[0], double.Parse(input[1]), input[2], input[3], input[4], int.Parse(input[5])));
                }
            }

            var output = employees
                .GroupBy(e => e.department)
                .Select(e => new
                {
                    Department = e.Key,
                    AverageSalary = e.Average(emp => emp.salary),
                    Employees = e.OrderByDescending(emp => emp.salary)
                })
                .OrderByDescending(emp => emp.AverageSalary)
                .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {output.Department}");
            foreach (var emp in output.Employees)
            {
                Console.WriteLine($"{emp.name} {emp.salary:F2} {emp.email} {emp.age}");
            }
        }
    }
}                                           

namespace _04.WorkForce
{
    using System;
    using System.Collections.Generic;

    using Interfaces;
    using Models;

    public class Startup
    {
        public static void Main()
        {
            var employees = new Dictionary<string, IEmployee>();
            var jobCollection = new JobCollection();

            var input = Console.ReadLine();
            while (input != "End")
            {
                var tokens = input.Split();

                if (tokens[0] == "StandartEmployee")
                {
                    var newEmployeeName = tokens[1];
                    IEmployee newEmployee = new StandartEmployee(newEmployeeName);
                    employees.Add(newEmployeeName, newEmployee);
                }
                else if (tokens[0] == "PartTimeEmployee")
                {
                    var newEmployeeName = tokens[1];
                    IEmployee newEmployee = new PartTimeEmployee(newEmployeeName);
                    employees.Add(newEmployeeName, newEmployee);
                }
                else if (tokens[0] == "Job")
                {
                    var newJobName = tokens[1];
                    int newJobHoursRequired = int.Parse(tokens[2]);
                    var employeeName = tokens[3];

                    IEmployee neededEmployee = employees[employeeName];
                    Job newJob = new Job(newJobName, newJobHoursRequired, neededEmployee);

                    jobCollection.AddJob(newJob);
                }
                else if (input == "Pass Week")
                {
                    jobCollection.Update();
                }
                else if (input == "Status")
                {
                    jobCollection.PrintStatus();
                }

                input = Console.ReadLine();
            }
        }
    }
}

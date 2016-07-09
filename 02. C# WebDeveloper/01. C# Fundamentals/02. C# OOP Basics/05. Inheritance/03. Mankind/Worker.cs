namespace _03.Mankind
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private double weekSalary;
        private double workHourPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHourPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHourPerDay = workHourPerDay;
        }

        public double WeekSalary
        {
            get { return weekSalary; }

            set
            {
                if (value < 10)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
                }

                weekSalary = value;
            }
        }

        public double WorkHourPerDay
        {
            get { return workHourPerDay; }

            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: workHoursPerDay");
                }

                workHourPerDay = value;
            }
        }

        public double GetHourSalary()
        {
            return this.WeekSalary/(this.WorkHourPerDay*5);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("First Name: ").Append(this.FirstName)
                .Append(Environment.NewLine)
                .Append("Last Name: ").Append(this.LastName)
                .Append(Environment.NewLine)
                .Append("Week Salary: ").Append($"{this.WeekSalary:F2}")
                .Append(Environment.NewLine)
                .Append("Hours per day: ").Append($"{this.WorkHourPerDay:F2}")
                .Append(Environment.NewLine)
                .Append("Salary per hour: ").Append($"{this.GetHourSalary():F2}")
                .Append(Environment.NewLine);

            return sb.ToString();
        }
    }
}
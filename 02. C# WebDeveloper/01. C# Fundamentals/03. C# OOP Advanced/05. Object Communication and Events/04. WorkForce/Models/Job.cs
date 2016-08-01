namespace _04.WorkForce.Models
{
    using System;

    using Interfaces;

    public class Job
    {
        public event EventHandler IsFinished;

        public Job(string name, int hoursOfWorkRequired, IEmployee employee)
        {
            this.Name = name;
            this.HoursOfWorkRequired = hoursOfWorkRequired;
            this.Employee = employee;
        }

        public string Name { get; private set; }
        public int HoursOfWorkRequired  { get; private set; }
        public IEmployee Employee  { get; private set; }

        public void Update()
        {
            this.HoursOfWorkRequired -= this.Employee.HoursPerWeek;

            if (this.HoursOfWorkRequired <= 0)
            {
                this.IsFinished?.Invoke(this, EventArgs.Empty);
            }
        }

        public override string ToString()
        {
            return $"Job: {this.Name} Hours Remaining: {this.HoursOfWorkRequired}";
        }
    }
}

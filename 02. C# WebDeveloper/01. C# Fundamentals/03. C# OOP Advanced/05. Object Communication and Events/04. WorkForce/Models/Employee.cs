namespace _04.WorkForce.Models
{
    using Interfaces;

    public abstract class Employee : IEmployee
    {
        protected Employee(string name, int hoursPerWeek)
        {
            this.Name = name;
            this.HoursPerWeek = hoursPerWeek;
        }

        public string Name { get; private set; }
        public int HoursPerWeek { get; private set; }
    }
}

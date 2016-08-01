namespace _04.WorkForce.Models
{
    public class PartTimeEmployee : Employee
    {
        private const int ThisHoursPerWeek = 20;

        public PartTimeEmployee(string name) 
            : base(name, ThisHoursPerWeek)
        {
        }
    }
}

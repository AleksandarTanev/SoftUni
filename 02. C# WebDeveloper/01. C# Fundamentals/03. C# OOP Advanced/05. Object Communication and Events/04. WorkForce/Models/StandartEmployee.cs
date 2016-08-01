namespace _04.WorkForce.Models
{
    public class StandartEmployee : Employee
    {
        private const int ThisHoursPerWeek = 40;

        public StandartEmployee(string name) 
            : base(name, ThisHoursPerWeek)
        {
        }
    }
}

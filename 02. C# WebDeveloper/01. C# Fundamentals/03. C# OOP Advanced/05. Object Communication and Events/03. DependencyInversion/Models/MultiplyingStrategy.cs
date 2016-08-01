namespace _03.DependencyInversion.Models
{
    using Interfaces;

    public class MultiplyingStrategy : ICalculationStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand * secondOperand;
        }
    }
}

namespace _05.FibonacciNumbers
{
    using System.Collections.Generic;

    public class Fibonacci
    {
        private List<long> fibNumbers;

        public Fibonacci()
        {
            fibNumbers = new List<long>();
            fibNumbers.Add(0);
            fibNumbers.Add(1);
        }

        public List<long> GetNumbersInRange(int startPosition, int endPosition)
        {
            CalculateFibNumbersUntil(endPosition);

            return fibNumbers.GetRange(startPosition, endPosition - startPosition);
        }

        private void CalculateFibNumbersUntil(int n)
        {
            if (fibNumbers.Count < n)
            {
                for (int i = fibNumbers.Count; i <= n; i++)
                {
                    fibNumbers.Add(fibNumbers[i - 1] + fibNumbers[i - 2]);
                }
            }
        }
    }
}

namespace _05.FibonacciNumbers
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int startPosition = int.Parse(Console.ReadLine());
            int endPosition = int.Parse(Console.ReadLine());

            var fib = new Fibonacci();
            var output = fib.GetNumbersInRange(startPosition, endPosition);

            Console.WriteLine(string.Join(", ", output));
        }
    }
}

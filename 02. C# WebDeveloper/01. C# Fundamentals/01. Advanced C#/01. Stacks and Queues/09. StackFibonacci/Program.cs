namespace _09.StackFibonacci
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var fibonacciStack = new Stack<long>();
            fibonacciStack.Push(1);
            fibonacciStack.Push(1);

            for (int i = 0; i < n - 2; i++)
            {
                long firstNumber = fibonacciStack.Pop();
                long secondNumber = fibonacciStack.Pop();
                
                long nextFibNumber = firstNumber + secondNumber;

                fibonacciStack.Push(firstNumber);
                fibonacciStack.Push(nextFibNumber);
            }

            Console.WriteLine(fibonacciStack.Peek());
        }
    }
}

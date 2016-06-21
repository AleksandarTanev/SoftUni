namespace _08.RecursiveFibonacci
{
    using System;

    class RecursiveFibonacci
    {
        private static long[] fibonaciNumbers;

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            fibonaciNumbers = new long[n + 2];
            fibonaciNumbers[0] = 1;
            fibonaciNumbers[1] = 1;
            GetFibonacci(n);

            Console.WriteLine(fibonaciNumbers[n - 1]);
        }

        private static void GetFibonacci(int n)
        {
            if (fibonaciNumbers[n] != 0)
            {
                return;
            }
            else
            {
                GetFibonacci(n - 1);
                GetFibonacci(n - 2);

                fibonaciNumbers[n] = fibonaciNumbers[n - 1] + fibonaciNumbers[n - 2];
            }
            
        }
    }
}

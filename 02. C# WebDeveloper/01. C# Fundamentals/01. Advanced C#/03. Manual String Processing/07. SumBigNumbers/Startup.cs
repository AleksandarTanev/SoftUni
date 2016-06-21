namespace _07.SumBigNumbers
{
    using System;

    class Startup
    {
        public static void Main()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            if (a.Length > b.Length)
            {
                a = "0" + a;
                b = b.PadLeft(a.Length, '0');
            }
            else
            {
                b = "0" + b;
                a = a.PadLeft(b.Length, '0');
            }

            string sum = string.Empty;
            int rest = 0;
            for (int i = a.Length - 1; i >= 0 ; i--)
            {
                int nextNumber = (int)char.GetNumericValue(a[i]) + (int)char.GetNumericValue(b[i]) + rest;
                sum = (nextNumber % 10) + sum;
                rest = nextNumber/10;
            }

            Console.WriteLine(sum.TrimStart('0'));
        }
    }
}

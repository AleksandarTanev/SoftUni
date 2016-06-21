namespace _08.MultiplyBigNumber
{
    using System;

    class Startup
    {
        public static void Main()
        {
            string number = "0" + Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            string sum = string.Empty;
            int rest = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int nextNumber = ((int)char.GetNumericValue(number[i]) * multiplier) + rest;
                sum = (nextNumber % 10) + sum;
                rest = nextNumber / 10;
            }

            string trimedSum = sum.TrimStart('0');
            if (trimedSum.Length == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(trimedSum);
            }
        }
    }
}

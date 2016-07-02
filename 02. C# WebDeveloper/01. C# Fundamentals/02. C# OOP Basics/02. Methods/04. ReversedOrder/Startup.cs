namespace _04.ReversedOrder
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var decNumber = new DecimalNumber(decimal.Parse(Console.ReadLine()));

            decNumber.PrintNumberReversed();
        }
    }
}

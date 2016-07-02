namespace _04.ReversedOrder
{
    using System;

    public class DecimalNumber
    {
        public decimal number;

        public DecimalNumber(decimal number)
        {
            this.number = number;
        }

        public void PrintNumberReversed()
        {
            string stringNumber = number.ToString();
            string result = "";

            for (int i = stringNumber.Length - 1; i >= 0; i--)
            {
                result += stringNumber[i];
            }

            Console.WriteLine(result);
        }
    }
}

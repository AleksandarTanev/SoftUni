namespace _03.LastDigitName
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var number = new Number(int.Parse(Console.ReadLine()));
            Console.WriteLine(number.LastDigitWord());
        }
    }
}

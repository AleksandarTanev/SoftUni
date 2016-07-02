namespace _10.DateModifier
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            var dateModdifier = new DateModifier(firstDate, secondDate);

            Console.WriteLine(dateModdifier.GetDifferenceInDays());
        }
    }
}
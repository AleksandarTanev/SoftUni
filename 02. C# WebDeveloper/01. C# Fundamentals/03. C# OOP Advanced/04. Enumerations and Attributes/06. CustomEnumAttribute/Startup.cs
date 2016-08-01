namespace _06.CustomEnumAttribute
{
    using System;

    using Enums;

    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            if (input == "Rank")
            {
                var attributes = typeof(CardRank).GetCustomAttributes(false);
                foreach (var attribute in attributes)
                {
                    Console.WriteLine(attribute);
                }
            }
            else if (input == "Suit")
            {
                var attributes = typeof(CardSuit).GetCustomAttributes(false);
                foreach (var attribute in attributes)
                {
                    Console.WriteLine(attribute);
                }
            }
        }
    }
}

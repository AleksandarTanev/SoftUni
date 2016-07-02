namespace _04.BeerCounter
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            while (input != "End")
            {
                var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int bought = int.Parse(tokens[0]);
                int drank = int.Parse(tokens[1]);

                BeerCounter.BuyBeer(bought);
                BeerCounter.DrinkBeer(drank);

                input = Console.ReadLine();
            }

            Console.WriteLine(BeerCounter.beerInStock + " " + BeerCounter.beersDrankCount);
        }
    }
}

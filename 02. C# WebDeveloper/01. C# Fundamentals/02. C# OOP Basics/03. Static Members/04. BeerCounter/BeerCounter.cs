namespace _04.BeerCounter
{
    public class BeerCounter
    {
        public static int beerInStock = 0;
        public static int beersDrankCount = 0;

        public static void BuyBeer(int bottlesCount)
        {
            beerInStock += bottlesCount;
        }

        public static void DrinkBeer(int bottlesCount)
        {
            beerInStock -= bottlesCount;
            beersDrankCount += bottlesCount;
        }
    }
}

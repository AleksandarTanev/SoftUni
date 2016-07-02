namespace _06.PlanckConstant
{
    public class Calculation
    {
        public static double p = 6.62606896e-34;
        public static double pi = 3.14159;

        public static double GetReducedPlankConstant()
        {
            return p / (2 * pi);
        }
    }
}

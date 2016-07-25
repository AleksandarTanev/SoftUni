namespace _11.Tuple
{
    using System;

    public class Startup
    {
        public static void Main()
        {

            var tokens = Console.ReadLine().Split();

            string name = tokens[0] + " " + tokens[1];
            string address = tokens[2];

            var tuple1 = new Models.Tuple<string, string>(name, address);
            Console.WriteLine(tuple1);

            tokens = Console.ReadLine().Split();

            name = tokens[0];
            var beerCount = int.Parse(tokens[1]);
            var tuple2 = new Models.Tuple<string, int>(name, beerCount);
            Console.WriteLine(tuple2);

            tokens = Console.ReadLine().Split();

            int num1 = int.Parse(tokens[0]);
            double num2 = double.Parse(tokens[1]);
            var tuple3 = new Models.Tuple<int, double>(num1, num2);
            Console.WriteLine(tuple3);
        }
    }
}

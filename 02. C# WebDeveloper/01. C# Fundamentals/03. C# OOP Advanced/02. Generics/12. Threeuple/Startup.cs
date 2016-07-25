namespace _12.Threeuple
{
    using System;

    public class Startup
    {
        public static void Main()
        {

            var tokens = Console.ReadLine().Split();

            string name = tokens[0] + " " + tokens[1];
            string address = tokens[2];
            string town = tokens[3];

            var tuple1 = new Models.Threeuple<string, string, string>(name, address, town);
            Console.WriteLine(tuple1);

            tokens = Console.ReadLine().Split();

            name = tokens[0];
            var beerCount = int.Parse(tokens[1]);
            bool isDrunk = false;

            if (tokens[2] == "drunk")
            {
                isDrunk = true;
            }

            var tuple2 = new Models.Threeuple<string, int, bool>(name, beerCount, isDrunk);
            Console.WriteLine(tuple2);

            tokens = Console.ReadLine().Split();

            name = tokens[0];
            var balance = double.Parse(tokens[1]);
            var bankName = tokens[2];

            var tuple3 = new Models.Threeuple<string, double, string>(name, balance, bankName);
            Console.WriteLine(tuple3);
        }
    }
}

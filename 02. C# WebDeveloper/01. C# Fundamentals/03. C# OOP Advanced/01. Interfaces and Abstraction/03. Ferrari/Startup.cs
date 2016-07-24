namespace _03.Ferrari
{
    using System;

    using Interfaces;
    using Models;

    public class Startup
    {
        public static void Main()
        {
            string driverName = Console.ReadLine();

            ICar car = new Ferrari("488-Spider", driverName);

            Console.Write(car.Model);
            Console.Write("/");

            car.Breaks();
            Console.Write("/");
            car.Gas();
            Console.Write("/");

            Console.Write(car.Driver);

            string ferrariName = typeof(Ferrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }
        }
    }
}

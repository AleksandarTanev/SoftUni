namespace _03.BoxОfInteger
{
    using System;

    using Models;

    public class Startup
    {
        public static void Main()
        {
            int nLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < nLines; i++)
            {
                int input = int.Parse(Console.ReadLine());
                var box = new Box<int>(input);
                Console.WriteLine(box);
            }
        }
    }
}

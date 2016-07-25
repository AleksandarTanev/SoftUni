namespace _02.BoxОfString
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
                string input = Console.ReadLine();
                var box = new Box<string>(input);
                Console.WriteLine(box);
            }
        }
    }
}

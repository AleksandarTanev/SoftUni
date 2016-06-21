namespace _02.StringLength
{
    using System;

    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            if (input.Length > 20)
            {
                input = input.Substring(0, 20);
            }

            string output = input.PadRight(20, '*');
            Console.WriteLine(output);
        }
    }
}

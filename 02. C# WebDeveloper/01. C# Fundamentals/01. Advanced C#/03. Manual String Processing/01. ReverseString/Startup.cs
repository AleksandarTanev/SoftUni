namespace _01.ReverseString
{
    using System.Text;
    using System;

    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder output = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                output.Append(input[i]);
            }

            Console.WriteLine(output);
        }
        
    }
}

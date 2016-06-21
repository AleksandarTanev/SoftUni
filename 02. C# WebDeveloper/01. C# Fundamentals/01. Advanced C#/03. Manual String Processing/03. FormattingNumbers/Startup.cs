namespace _03.FormattingNumbers
{
    using System;

    class Startup
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new char[] {' ', '\n', '\t'}, StringSplitOptions.RemoveEmptyEntries);

            int a = int.Parse(input[0]);
            double b = double.Parse(input[1]);
            double c = double.Parse(input[2]);

            Console.WriteLine("|{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|", a, Convert.ToString(a, 2).PadLeft(10, '0').Substring(0, 10), b, c);
            
        }
    }
}

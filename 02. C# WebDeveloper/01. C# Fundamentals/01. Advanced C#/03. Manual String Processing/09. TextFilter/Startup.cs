namespace _09.TextFilter
{
    using System;

    class Startup
    {
        static void Main()
        {
            string[] stringsToRemove = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string givenText = Console.ReadLine();

            string output = givenText;

            for (int i = 0; i < stringsToRemove.Length; i++)
            {
                output = output.Replace(stringsToRemove[i], new string('*', stringsToRemove[i].Length));
            }

            Console.WriteLine(output);
        }
    }
}

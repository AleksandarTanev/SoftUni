namespace _10.UnicodeCharacters
{
    using System;

    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                Console.Write("\\u" + ((int)charArray[i]).ToString("X4").ToLower());
            }

            Console.WriteLine();
        }
    }
}

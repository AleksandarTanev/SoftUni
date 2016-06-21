namespace _13.MagicExchangeableWords
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Trim().Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            HashSet<char> firstWord = new HashSet<char>(input[0]);
            HashSet<char> secondWord = new HashSet<char>(input[1]);
            if (firstWord.Count == secondWord.Count)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}

using System;

namespace _12.CharacterMultiplier
{
    class Startup
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Trim().Split(new char[] {' ', '\t', '\n'}, StringSplitOptions.RemoveEmptyEntries);

            string firstString = input[0];
            string secondString = input[1];

            char leftPadChar = (char) 1;

            if (firstString.Length > secondString.Length)
            {
                secondString = secondString.PadRight(firstString.Length, leftPadChar);
            }
            else
            {
                firstString = firstString.PadRight(secondString.Length, leftPadChar);
            }

            long sum = 0;

            for (int i = 0; i < firstString.Length; i++)
            {
                sum += (int) firstString[i]*(int) secondString[i];
            }

            Console.WriteLine(sum);
        }
    }
}

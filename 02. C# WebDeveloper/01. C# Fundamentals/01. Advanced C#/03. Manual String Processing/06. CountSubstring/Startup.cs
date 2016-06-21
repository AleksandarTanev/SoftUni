namespace _06.CountSubstring
{
    using System;

    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string stringToCheck = Console.ReadLine();

            Console.WriteLine(CheckOccurrence(input, stringToCheck));
        }

        static int CheckOccurrence(string inputString, string stringToCheck)
        {
            inputString = inputString.ToUpper();
            stringToCheck = stringToCheck.ToUpper();

            int indexStart = 0;
            int count = 0;

            while (indexStart <= inputString.Length)
            {
                int checkedIndex = inputString.IndexOf(stringToCheck, indexStart);

                if (checkedIndex >= 0)
                {
                    indexStart = checkedIndex + 1;
                    count++;
                }
                else
                {
                    break;
                }

            }

            return count;
        }
    }
}

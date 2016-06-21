namespace _14.LettersChangeNumbers
{
    using System;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            string[] inputArray = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            double sum = 0f;
            double tempNumber;

            foreach (string item in inputArray)
            {
                tempNumber = double.Parse(item.Substring(1, item.Length - 2));

                if (Char.IsUpper(item[0]))
                {
                    tempNumber = tempNumber / GetPositionInTheAlphabet(item[0]);
                }
                else
                {
                    tempNumber = tempNumber * GetPositionInTheAlphabet(item[0]);
                }

                if (Char.IsUpper(item[item.Length - 1]))
                {
                    tempNumber = tempNumber - GetPositionInTheAlphabet(item[item.Length - 1]);
                }
                else
                {
                    tempNumber = tempNumber + GetPositionInTheAlphabet(item[item.Length - 1]);
                }

                sum += tempNumber;
            }

            Console.WriteLine("{0:F2}", sum);
        }
        
        static int GetPositionInTheAlphabet(char letter)
        {
            int possition = string.CompareOrdinal(letter.ToString().ToLower(), "a");
            return possition + 1;
        }
    }
}

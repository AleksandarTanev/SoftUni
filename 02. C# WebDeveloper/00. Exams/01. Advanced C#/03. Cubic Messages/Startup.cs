namespace _03.Cubic_Messages
{
    using System;
    using System.Text.RegularExpressions;

    public class Startup
    {
        public static void Main()
        {
            string pattern = @"^([0-9]+)([A-Za-z]+)[^a-zA-Z0-9]*?([0-9]*)[^a-zA-Z0-9]*?$";

            Regex rgx = new Regex(pattern);

            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "Over!")
                {
                    break;
                }
                int lengthCondition = int.Parse(Console.ReadLine());

                if (rgx.IsMatch(inputLine))
                {
                    Match matchedValues = rgx.Match(inputLine);
                    string firstNumbers = matchedValues.Groups[1].ToString();
                    string message = matchedValues.Groups[2].ToString();
                    string secondNumbers = matchedValues.Groups[3].ToString();

                    if (message.Length == lengthCondition)
                    {
                        Print(firstNumbers, message, secondNumbers);
                    }
                }
            }
        }

        private static void Print(string firstNumbers, string message, string secondNumbers)
        {
            string verificationCode = string.Empty;

            for (int i = 0; i < firstNumbers.Length; i++)
            {
                int num = int.Parse(firstNumbers[i].ToString());
                if (num < message.Length)
                {
                    verificationCode += message[num];
                }
                else
                {
                    verificationCode += " ";
                }
            }

            for (int i = 0; i < secondNumbers.Length; i++)
            {
                int num = int.Parse(secondNumbers[i].ToString());
                if (num < message.Length)
                {
                    verificationCode += message[num];
                }
                else
                {
                    verificationCode += " ";
                }
            }

            Console.WriteLine($"{message} == {verificationCode}");
        }
    }
}

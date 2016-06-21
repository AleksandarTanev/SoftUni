namespace _11.Palindromes
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            SortedSet<string> palindromes = new SortedSet<string>();

            string[] words = input.Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                int indexOfPal = 0;
                bool isPalindrom = true;

                while (isPalindrom && indexOfPal < word.Length / 2)
                {
                    if (word[indexOfPal] != word[word.Length - 1 - indexOfPal])
                    {
                        isPalindrom = false;
                    }

                    indexOfPal++;
                }

                if (isPalindrom && !palindromes.Contains(word))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine("[" + string.Join(", ", palindromes) + "]");
        }
    }
}

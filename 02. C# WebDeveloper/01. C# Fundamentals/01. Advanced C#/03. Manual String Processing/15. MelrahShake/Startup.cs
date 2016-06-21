namespace _15.MelrahShake
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (true)
            {
                bool matches = false;

                int firstMatchIndex = input.IndexOf(pattern);
                int lastMatchIndex = input.LastIndexOf(pattern);

                if (firstMatchIndex >= 0 && lastMatchIndex >= 0 && firstMatchIndex != lastMatchIndex)
                {
                    matches = true;

                    input = input.Remove(firstMatchIndex, pattern.Length);

                    lastMatchIndex = input.LastIndexOf(pattern);
                    if (lastMatchIndex >= 0)
                    {
                        input = input.Remove(lastMatchIndex, pattern.Length);
                    }
                }

                if (matches)
                {
                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    break;
                }

                if (input.Length < pattern.Length)
                {
                    break;
                }

                if (pattern.Length > 1)
                {
                    pattern = pattern.Remove(pattern.Length/2, 1);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(input);
        }
    }
}

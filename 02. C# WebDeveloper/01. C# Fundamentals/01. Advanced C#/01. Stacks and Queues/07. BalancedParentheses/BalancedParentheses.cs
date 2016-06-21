namespace _07.BalancedParentheses
{
    using System;
    using System.Collections.Generic;

    class BalancedParentheses
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();

            Stack<char> paranthesesStack = new Stack<char>();

            int i = 0;
            while (i < input.Length)
            {
                char currentChar = input[i];

                if (currentChar == '(')
                {
                    paranthesesStack.Push(')');
                }
                else if (currentChar == '[')
                {
                    paranthesesStack.Push(']');
                }
                else if (currentChar == '{')
                {
                    paranthesesStack.Push('}');
                }
                else
                {
                    if (paranthesesStack.Count != 0)
                    {
                        if (currentChar != paranthesesStack.Pop())
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                i++;
            }

            Console.WriteLine("YES");
        }
    }
}

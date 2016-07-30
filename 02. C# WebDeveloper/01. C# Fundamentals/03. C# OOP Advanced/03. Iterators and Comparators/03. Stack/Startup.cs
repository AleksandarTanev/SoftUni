namespace _03.Stack
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var myStack = new MyStack<int>();

            var input = Console.ReadLine();
            while (input != "END")
            {
                var tokens = input.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Push")
                {
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        myStack.Push(int.Parse(tokens[i]));
                    }
                }
                else if (tokens[0] == "Pop")
                {
                    try
                    {
                        myStack.Pop();
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}

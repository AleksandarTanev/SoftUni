namespace _10.SimpleTextEditor
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        private static Stack<string> textEditor = new Stack<string>();

        static void Main()
        {
            int numOfLines = int.Parse(Console.ReadLine());

            textEditor.Push("");
            for (int i = 0; i < numOfLines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "1")
                {
                    string previousText = textEditor.Peek();

                    textEditor.Push(previousText + input[1]);
                }
                else if (input[0] == "2")
                {
                    string previousText = textEditor.Peek();
                    int count = int.Parse(input[1]);

                    textEditor.Push(previousText.Substring(0, previousText.Length - count));
                }
                else if (input[0] == "3")
                {
                    string previousText = textEditor.Peek();
                    int index = int.Parse(input[1]);

                    Console.WriteLine(previousText[index - 1]);
                }
                else if (input[0] == "4")
                {
                    textEditor.Pop();
                }
            }
        }
    }
}

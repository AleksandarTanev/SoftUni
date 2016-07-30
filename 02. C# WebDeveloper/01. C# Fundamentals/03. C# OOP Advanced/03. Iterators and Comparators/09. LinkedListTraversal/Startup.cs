namespace _09.LinkedListTraversal
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var myLinkedList = new MyLinkedList<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();

                string command = tokens[0];
                int number = int.Parse(tokens[1]);

                if (command == "Add")
                {
                    myLinkedList.Add(number);
                }
                else
                {
                    myLinkedList.Remove(number);
                }
            }

            Console.WriteLine(myLinkedList.Count);
            Console.WriteLine(string.Join(" ", myLinkedList));
        }
    }
}

namespace _01.ListyIterator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            List<string> collection = input.Split().ToList();
            collection.RemoveAt(0);

            var myList = new ListyIterator<string>(collection);

            input = Console.ReadLine();
            while (input != "END")
            {
                if (input == "HasNext")
                {
                    Console.WriteLine(myList.HasNext());
                }
                else if (input == "Move")
                {
                    Console.WriteLine(myList.Move());
                }
                else if (input == "Print")
                {
                    try
                    {
                        myList.Print();
                    }
                    catch (IndexOutOfRangeException ioore)
                    {
                        Console.WriteLine(ioore.Message);
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}

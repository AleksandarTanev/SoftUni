namespace _09.CustomListSorter
{
    using System;
    using IO;
    using Models;

    public class Startup
    {
        public static void Main()
        {
            var collection = new CustomList<string>();
            var interpreter = new CommandInterpreter(collection);

            string input = Console.ReadLine();
            while (input != "END")
            {
                var tokens = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                interpreter.InterpretCommand(tokens);

                input = Console.ReadLine();
            }
        }
    }
}

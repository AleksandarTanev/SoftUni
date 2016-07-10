namespace System_Split.IO
{
    using System;

    using Exceptions;

    public class InputReader
    {
        private const string endCommand = "System Split";
        private CommandInterpreter commandInterpreter;

        public InputReader(CommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void StartReadingCommands()
        {
            string input = Console.ReadLine();

            while (true)
            {
                try
                {
                    this.commandInterpreter.InterpretCommand(input);
                }
                catch (InvalidHardwareType ihte)
                {
                    Console.WriteLine(ihte.Message);
                }
                catch (InvalidSoftwareType iste)
                {
                    Console.WriteLine(iste.Message);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                if (input == endCommand)
                {
                    break;
                }

                input = Console.ReadLine();
            }
        }
    }
}

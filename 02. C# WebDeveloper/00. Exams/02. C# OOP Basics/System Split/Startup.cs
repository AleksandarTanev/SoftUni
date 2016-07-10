namespace System_Split
{
    using IO;
    using Repository;

    public class Startup
    {
        public static void Main()
        {
            SystemRepository repository = new SystemRepository();
            CommandInterpreter commandInterpreter = new CommandInterpreter(repository);
            InputReader inputReader = new InputReader(commandInterpreter);

            inputReader.StartReadingCommands();
        }
    }
}

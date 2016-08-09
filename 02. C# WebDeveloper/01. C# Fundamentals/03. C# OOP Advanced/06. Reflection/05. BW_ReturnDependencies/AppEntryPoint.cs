namespace _05.BW_ReturnDependencies
{
    using Contracts;
    using Core;
    using Core.Factories;
    using Data;

    public class AppEntryPoint
    {
        public static void Main()
        {
            IRepository repository = new UnitRepository();
            IUnitFactory unitFactory = new UnitFactory();
            IInterpreter interpreter = new CommandInterpreter(repository, unitFactory);

            IRunnable engine = new Engine(repository, unitFactory, interpreter);
            engine.Run();
        }
    }
}

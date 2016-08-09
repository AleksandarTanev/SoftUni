namespace  _05.BW_ReturnDependencies.Core
{
    using System;
    using Contracts;

    class Engine : IRunnable
    {
        private IRepository repository;
        private IUnitFactory unitFactory;
        private IInterpreter interpreter;

        public Engine(IRepository repository, IUnitFactory unitFactory, IInterpreter interpreter)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
            this.interpreter = interpreter;
        }
        
        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    interpreter.InterpredCommand(input);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}

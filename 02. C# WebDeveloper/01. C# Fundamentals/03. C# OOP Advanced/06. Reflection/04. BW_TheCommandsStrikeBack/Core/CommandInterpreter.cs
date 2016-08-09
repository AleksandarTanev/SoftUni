namespace _04.BW_TheCommandsStrikeBack.Core
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Contracts;
    using Commands;
    using Attributes;

    public class CommandInterpreter : IInterpreter
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public CommandInterpreter(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public void InterpredCommand(string input)
        {
            string[] data = input.Split(' ');
            string commandName = data[0].ToLower();

            try
            {
                IExecutable command = this.ParseCommand(data, commandName);
                Console.WriteLine(command.Execute());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private IExecutable ParseCommand(string[] data, string commandName)
        {
            if (commandName == "fight")
            {
                Environment.Exit(0);
            }

            object[] parametersForConstruction = new object[]
            {
                data, this.repository, this.unitFactory
            };

            Type typeOfCommand = Assembly.GetExecutingAssembly()
                .GetTypes()
                .First(type => type.GetCustomAttributes(typeof(AliasAttribute))
                    .Where(atr => atr.Equals(commandName))
                    .ToArray()
                    .Length > 0);

            Command exe = (Command)Activator.CreateInstance(typeOfCommand, parametersForConstruction);

            return exe;
        }
    }
}

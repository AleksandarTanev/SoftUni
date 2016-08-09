namespace _05.BW_ReturnDependencies.Core
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Contracts;
    using Commands;
    using Attributes;

    public class CommandInterpreter : IInterpreter
    {
        private readonly IRepository repository;
        private readonly IUnitFactory unitFactory;

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
                data
            };

            Type typeOfCommand = Assembly.GetExecutingAssembly()
                .GetTypes()
                .First(type => type.GetCustomAttributes(typeof(AliasAttribute))
                    .Where(atr => atr.Equals(commandName))
                    .ToArray()
                    .Length > 0);

            Command exe = (Command)Activator.CreateInstance(typeOfCommand, parametersForConstruction);

            Type typeOfInterpreter = typeof(CommandInterpreter);

            FieldInfo[] fieldsOfCommand = typeOfCommand.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo[] fieldsOfInterpreter = typeOfInterpreter.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var fieldOfCommand in fieldsOfCommand)
            {
                Attribute atrAttribute = fieldOfCommand.GetCustomAttribute(typeof(InjectAttribute));
                if (atrAttribute != null)
                {
                    if (fieldsOfInterpreter.Any(x => x.FieldType == fieldOfCommand.FieldType))
                    {
                        fieldOfCommand.SetValue(exe, fieldsOfInterpreter.First(x => x.FieldType == fieldOfCommand.FieldType)
                            .GetValue(this));
                    }
                }
            }

            return exe;
        }
    }
}

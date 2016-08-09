namespace _05.BW_ReturnDependencies.Core.Commands
{
    using Contracts;

    public abstract class Command : IExecutable
    {
        private string[] data;

        public Command(string[] data)
        {
            this.Data = data;
        }

        public string[] Data
        {
            get
            {
                return data;
            }

            private set
            {
                data = value;
            }
        }

        public abstract string Execute();
    }
}

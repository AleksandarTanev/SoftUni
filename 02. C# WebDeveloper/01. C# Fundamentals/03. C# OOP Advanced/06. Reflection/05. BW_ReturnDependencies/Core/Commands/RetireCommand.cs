namespace _05.BW_ReturnDependencies.Core.Commands
{
    using Contracts;
    using Attributes;

    [Alias("retire")]
    public class RetireCommand : Command
    {
        [Inject]
        private IRepository repository;

        public RetireCommand(string[] data) 
            : base(data)
        {
        }

        public override string Execute()
        {
            string typeToRetire = this.Data[1];

            bool isRemoved = this.repository.RemoveUnit(typeToRetire);

            if (isRemoved)
            {
                return $"{typeToRetire} retired!";
            }

            return $"No such units in repository.";
        }
    }
}

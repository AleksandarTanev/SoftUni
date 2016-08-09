namespace _04.BW_TheCommandsStrikeBack.Core.Commands
{
    using Contracts;
    using Attributes;

    [Alias("retire")]
    public class RetireCommand : Command
    {
        public RetireCommand(string[] data, IRepository repository, IUnitFactory unitFactory) 
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string typeToRetire = this.Data[1];

            bool isRemoved = this.Repository.RemoveUnit(typeToRetire);

            if (isRemoved)
            {
                return $"{typeToRetire} retired!";
            }

            return $"No such units in repository.";
        }
    }
}

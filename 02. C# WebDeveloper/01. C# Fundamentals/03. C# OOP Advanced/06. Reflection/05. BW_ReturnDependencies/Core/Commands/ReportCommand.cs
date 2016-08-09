namespace _05.BW_ReturnDependencies.Core.Commands
{
    using Attributes;
    using Contracts;

    [Alias("report")]
    public class ReportCommand : Command
    {
        [Inject]
        private IRepository repository;

        public ReportCommand(string[] data) 
            : base(data)
        {
        }

        public override string Execute()
        {
            string output = this.repository.Statistics;
            return output;
        }
    }
}

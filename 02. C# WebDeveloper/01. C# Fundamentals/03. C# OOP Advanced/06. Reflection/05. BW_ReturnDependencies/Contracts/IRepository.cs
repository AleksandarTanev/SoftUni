namespace  _05.BW_ReturnDependencies.Contracts
{
    public interface IRepository
    {
        void AddUnit(IUnit unit);
        string Statistics { get; }
        bool RemoveUnit(string unitType);
    }
}

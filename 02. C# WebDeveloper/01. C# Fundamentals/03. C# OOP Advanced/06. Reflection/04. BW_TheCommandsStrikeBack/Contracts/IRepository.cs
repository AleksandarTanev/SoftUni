namespace  _04.BW_TheCommandsStrikeBack.Contracts
{
    public interface IRepository
    {
        void AddUnit(IUnit unit);
        string Statistics { get; }
        bool RemoveUnit(string unitType);
    }
}

namespace _03.Ferrari.Interfaces
{
    public interface ICar : IMovable, IStoppable
    {
        string Model { get; set; }
        string Driver { get; set; }
    }
}

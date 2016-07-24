namespace _06.BirthdayCelebrations.Interfaces
{
    public interface ICitizen : IBirthable
    {
        string Name { get; }
        int Age { get; }
    }
}

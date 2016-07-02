namespace _02.UniqueNames
{
    public class Student
    {
        public string name;

        public Student(string name)
        {
            this.name = name;
        }

        public override bool Equals(object other)
        {
            return this.GetHashCode().Equals(other.GetHashCode());
        }

        public override int GetHashCode()
        {
            return this.name.GetHashCode();
        }

    }
}

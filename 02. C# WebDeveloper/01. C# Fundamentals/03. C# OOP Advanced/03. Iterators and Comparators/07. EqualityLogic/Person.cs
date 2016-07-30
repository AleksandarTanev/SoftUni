namespace _07.EqualityLogic
{
    using System;

    public class Person : IComparable<Person>, IEquatable<Person>
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int CompareTo(Person other)
        {
            return this.GetHashCode().CompareTo(other.GetHashCode());
        }

        public override int GetHashCode()
        {
            return this.name.GetHashCode() * 17 + this.age.GetHashCode();
        }

        public bool Equals(Person other)
        {
            return this.GetHashCode().CompareTo(other.GetHashCode()) == 0;
        }
    }
}

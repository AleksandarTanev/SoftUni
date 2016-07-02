namespace _12.PrintPeople
{
    using System;

    public class Person : IComparable<Person>
    {
        public string name;
        public int age;
        public string occupation;

        public Person(string name, int age, string occupation)
        {
            this.name = name;
            this.age = age;
            this.occupation = occupation;
        }

        public override string ToString()
        {
            string output = $"{this.name} - age: {this.age}, occupation: {this.occupation}";

            return output;
        }

        public int CompareTo(Person other)
        {
            if (this.age < other.age)
            {
                return -1;
            }
            else if (this.age > other.age)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}

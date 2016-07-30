namespace _05.ComparingObjects
{
    using System;

    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public Person(string name, int age, string town)
        {
            this.name = name;
            this.age = age;
            this.town = town;
        }

        public int CompareTo(Person other)
        {
            int compareResult = 0;

            if (this.name.CompareTo(other.name) != 0)
            {
                compareResult = this.name.CompareTo(other.name);
            }
            else
            {
                if (this.age.CompareTo(other.age) != 0)
                {
                    compareResult = this.age.CompareTo(other.age);

                }
                else
                {
                    if (this.town.CompareTo(other.town) != 0)
                    {
                        compareResult = this.town.CompareTo(other.town);

                    }
                }
            }

            return compareResult;
        }
    }
}

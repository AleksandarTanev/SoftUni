namespace _06.StrategyPattern
{
    using System.Collections.Generic;

    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"{this.name} {this.age}";
        }

        public class PersonByNameComparer : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                int result;

                if (x.name.Length.CompareTo(y.name.Length) == 0)
                {
                    result = x.name.ToLower()[0].CompareTo(y.name.ToLower()[0]);
                }
                else
                {
                    result = x.name.Length.CompareTo(y.name.Length);
                }

                return result;
            }
        }

        public class PersonByAgeComparer : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                return x.age.CompareTo(y.age);
            }
        }
    }
}

namespace _02.OldestFamilyMember
{
    using System.Collections.Generic;
    using System.Linq;

    public class Family
    {
        private List<Person> family;

        public Family()
        {
            this.family = new List<Person>();
        }

        public void AddMember(Person person)
        {
            family.Add(person);
        }

        public Person GetOldestMember()
        {
            Person oldest = family.OrderByDescending(p => p.age).FirstOrDefault();

            return oldest;
        }
    }
}

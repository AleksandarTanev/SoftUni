namespace _10.FamilyTree
{
    using System.Collections.Generic;

    public class Person
    {
        public string name = string.Empty;
        public string birthday = string.Empty;
        public List<Person> parents = new List<Person>();
        public List<Person> children = new List<Person>();

        public override string ToString()
        {
            string result = string.Empty;

            result += this.name + " " + this.birthday + "\n";

            result += "Parents:";
            foreach (var parent in this.parents)
            {
                result += "\n" + parent.name + " " + parent.birthday;
            }

            result += "\nChildren:";
            foreach (var child in this.children)
            {
                result += "\n" + child.name + " " + child.birthday;
            }

            return result;
        }
    }
}

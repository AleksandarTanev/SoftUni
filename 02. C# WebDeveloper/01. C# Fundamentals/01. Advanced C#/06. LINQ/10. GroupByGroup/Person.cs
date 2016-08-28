namespace _10.GroupByGroup
{
    public class Person
    {
        private string name;
        private int @group;

        public Person(string name, int @group)
        {
            this.Name = name;
            this.Group = @group;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Group
        {
            get
            {
                return this.@group;
            }

            set
            {
                this.@group = value;
            }
        }
    }
}

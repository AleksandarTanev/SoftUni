namespace System_Split.Models
{
    using System;

    public abstract class ComputerComponent
    {
        private string name;
        private string type;

        protected ComputerComponent(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        public virtual string Name
        {
            get
            {
                return name;
            }

            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException($"This {nameof(this.Name)} cannot be empty.");
                }

                name = value;
            }
        }

        public virtual string Type
        {
            get
            {
                return type;
            }

            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException($"This {nameof(this.Type)} cannot be empty.");
                }

                type = value;
            }
        }
    }
}

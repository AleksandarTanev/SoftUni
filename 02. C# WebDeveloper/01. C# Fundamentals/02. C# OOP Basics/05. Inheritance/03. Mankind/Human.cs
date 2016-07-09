namespace _03.Mankind
{
    using System;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public virtual string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if ((int)value[0] < 65 || (int)value[0] > 90)
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: {nameof(this.firstName)}");
                }

                this.firstName = value;
            }
        }

        public virtual string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                if ((int)value[0] < 65 || (int)value[0] > 90)
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: {nameof(this.lastName)}");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException($"Expected length at least 3 symbols! Argument: {nameof(this.lastName)}");
                }

                this.lastName = value;
            }
        }
    }
}

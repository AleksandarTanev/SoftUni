namespace _03.Mankind
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return facultyNumber;
            }

            set
            {
                if (value.Length < 5 || value.Length > 10 || !Regex.IsMatch(value.Trim(), @"^[a-zA-Z0-9]*$"))
                {
                    throw new ArgumentException($"Invalid faculty number!");
                }

                this.facultyNumber = value.Trim();
            }
        }

        public override string FirstName
        {
            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException($"Expected length at least 4 symbols! Argument: firstName");
                }

                base.FirstName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("First Name: ").Append(this.FirstName)
                .Append(Environment.NewLine)
                .Append("Last Name: ").Append(this.LastName)
                .Append(Environment.NewLine)
                .Append("Faculty number: ").Append(this.FacultyNumber)
                .Append(Environment.NewLine);

            return sb.ToString();
        }
    }
}

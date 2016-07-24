namespace _06.BirthdayCelebrations.Models
{
    using System.Text.RegularExpressions;

    using Interfaces;

    public abstract class Identity : IIdentifiable
    {
        protected Identity(string id)
        {
            this.Id = id;
        }

        public string Id { get; private set; }

        public bool CheckIdValidity(string pattern)
        {
            if (Regex.IsMatch(this.Id, @"^.*?" + pattern + "$"))
            {
                return true;
            }

            return false;
        }
    }
}

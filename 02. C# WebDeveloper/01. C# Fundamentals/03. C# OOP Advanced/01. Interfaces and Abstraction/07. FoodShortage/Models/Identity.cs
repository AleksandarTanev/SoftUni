namespace _07.FoodShortage.Models
{
    using Interfaces;

    public abstract class Identity : IIdentifiable
    {
        protected Identity(string id)
        {
            this.Id = id;
        }

        public string Id { get; private set; }
    }
}

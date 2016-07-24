namespace _07.FoodShortage.Models
{
    using Interfaces;

    public class Robot : Identity, IRobot
    {
        public Robot(string model, string id) : base(id)
        {
            this.Model = model;
        }

        public string Model { get; }
    }
}

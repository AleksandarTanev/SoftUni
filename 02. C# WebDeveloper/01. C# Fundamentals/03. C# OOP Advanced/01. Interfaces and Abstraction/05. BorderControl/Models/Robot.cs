namespace _05.BorderControl.Models
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

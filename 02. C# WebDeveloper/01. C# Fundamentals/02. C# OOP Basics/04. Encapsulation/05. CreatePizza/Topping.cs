namespace _05.CreatePizza
{
    using System;

    public class Topping
    {
        private string type;
        private double weight;
        private double caloriesPerGram;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;

            this.CaloriesPerGram = 2;
        }

        private string Type
        {
            get
            {
                return type;
            }

            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                type = value;
            }
        }

        private double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                }

                weight = value;
            }
        }

        private double CaloriesPerGram
        {
            get
            {
                double modifier = 1;

                if (this.Type.ToLower() == "meat")
                {
                    modifier *= 1.2;
                }
                else if (this.Type.ToLower() == "veggies")
                {
                    modifier *= 0.8;
                }
                else if (this.Type.ToLower() == "cheese")
                {
                    modifier *= 1.1;
                }
                else if (this.Type.ToLower() == "sauce")
                {
                    modifier *= 0.9;
                }

                return caloriesPerGram * modifier;
            }

            set
            {
                caloriesPerGram = value;
            }
        }

        public double GetCalories()
        {
            return this.Weight * this.CaloriesPerGram;
        }
    }
}

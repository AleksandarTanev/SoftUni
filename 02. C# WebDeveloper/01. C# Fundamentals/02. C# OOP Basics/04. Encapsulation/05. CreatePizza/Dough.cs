namespace _05.CreatePizza
{
    using System;

    public class Dough
    {
        private string flourType;
        private string bakingTech;
        private double weight;
        private double caloriesPerGram;


        public Dough(string flourType, string bakingTech, double weight)
        {
            this.FlourType = flourType;
            this.BakingTech = bakingTech;
            this.Weight = weight;

            this.CaloriesPerGram = 2;
        }

        private string FlourType
        {
            get
            {
                return flourType;
            }

            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException($"Invalid type of dough.");
                }

                flourType = value;
            }
        }

        private string BakingTech
        {
            get
            {
                return bakingTech;
            }

            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException($"Invalid type of dough.");
                }

                bakingTech = value;
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
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException($"Dough weight should be in the range [1..200].");
                }

                weight = value;
            }
        }

        private double CaloriesPerGram
        {
            get
            {
                double modifier = 1;
                if (this.FlourType.ToLower() == "white")
                {
                    modifier *= 1.5;
                }
                else if (this.FlourType.ToLower() == "wholegrain")
                {
                    modifier *= 1.0;
                }

                if (this.BakingTech.ToLower() == "crispy")
                {
                    modifier *= 0.9;
                }
                else if (this.BakingTech.ToLower() == "chewy")
                {
                    modifier *= 1.1;
                }
                else if (this.BakingTech.ToLower() == "homemade")
                {
                    modifier *= 1.0;
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

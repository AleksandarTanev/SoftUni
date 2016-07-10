namespace _03.WildFarm.Animals
{
    public abstract class Mammal : Animal
    {
        private string livingRegion;

        public Mammal(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion
        {
            get
            {
                return livingRegion;
            }

            set
            {
                livingRegion = value;
            }
        }

        public override string ToString()
        {
            string output = $"{this.GetType().Name}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";

            return output;
        }
    }
}

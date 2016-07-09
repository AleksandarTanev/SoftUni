namespace _04.MordorCrueltyPlan
{
    public class Gandalf
    {
        private int hapiness;

        public Gandalf()
        {
            this.Hapiness = 0;
        }

        public int Hapiness
        {
            get
            {
                return hapiness;
            }

            set
            {
                hapiness = value;
            }
        }

        public void Eat(Food food)
        {
            this.Hapiness += food.PointsOfHapiness;
        }

        public string GetMood()
        {
            string mood = "";

            if (this.Hapiness < -5)
            {
                mood = "Angry";
            }
            else if (this.Hapiness >= -5 && this.Hapiness <= 0)
            {
                mood = "Sad";
            }
            else if (this.Hapiness >= -5 && this.Hapiness <= 15)
            {
                mood = "Happy";
            }
            else if (this.Hapiness > 15)
            {
                mood = "JavaScript";
            }
            return mood;
        }
    }
}

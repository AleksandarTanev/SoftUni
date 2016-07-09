namespace _04.MordorCrueltyPlan
{
    public class Food
    {
        private int pointsOfHapiness;

        public Food(int pointsOfHapiness)
        {
            this.PointsOfHapiness = pointsOfHapiness;
        }

        public int PointsOfHapiness
        {
            get
            {
                return pointsOfHapiness;
            }

            set
            {
                pointsOfHapiness = value;
            }
        }
    }
}

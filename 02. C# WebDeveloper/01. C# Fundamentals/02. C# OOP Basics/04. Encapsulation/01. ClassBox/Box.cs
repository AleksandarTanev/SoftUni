namespace _01.ClassBox
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double Volume()
        {
            double result = length * width * height;

            return result;
        }

        public double LateralSurfaceArea()
        {
            double result = 2 * length * height + 2 * width * height;

            return result;
        }

        public double SurfaceArea()
        {
            double result = 2 * length * height + 2 * width * height + +2 * width * length;

            return result;
        }
    }
}
